using Entities;
using Service;
using System.Collections.Generic;
using System.Linq;


namespace PlayerStats
{
    public partial class FrmEstadisticas : frmMenuPrincipal
    {
 
        public FrmEstadisticas()
        {
            InitializeComponent();
        }

        private void FrmEstadisticas_Load(object sender, EventArgs e)
        {
            SetControlsAndVisor();

        }


        private  void ActualizarVisor()
        {
            //Hacerlo generico pasando List<T>, U para referenciar el type deol a estadistica con gettype().
            lvVisor.Clear();
            lvVisor.Items.Clear();

            List<Estadisticas> estadisticas = Deportistas.Atletas[Deportistas.INDEX].Estadisticas;
            //estadisticas.ConvertAll(e => new EFutbolista());
            if (estadisticas is not null && estadisticas.Count > 0)
            {
                foreach (Estadisticas v in estadisticas)
                {
                    if (v is IEstadisticaFutbolista value)
                        lvVisor.Items.Add($"Vs {value.Rival} ({value.Fecha.ToShortDateString()}) | {value.Competicion} - Estadio {value.Estadio}");
                }

                lbVisorCargado.ForeColor = Color.Green;
                lbVisorCargado.Text = $"Estadisticas Cargadas : {Deportistas.Atletas[Deportistas.INDEX].Estadisticas.Count()}";
            }
            else
            {
                lbVisorCargado.ForeColor = Color.Red;
                lbVisorCargado.Text = "No hay estadisticas cargadas aun.";
            }

        }

        protected override void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmCargarEstadisticas frm = new FrmCargarEstadisticaFutbolista();


            this.Hide();
            frm.IsModifier = false;
            frm.ShowDialog();

            this.Show();
            ActualizarVisor();
        }

        protected override void btnVer_Click(object sender, EventArgs e)
        {
            if (lvVisor.SelectedIndices.Count > 0)
            {
                int i = lvVisor.SelectedIndices[0];

                if (i == -1)
                    MessageBox.Show("Seleccione Una Estadistica", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    FrmVerEstadistica frm = new FrmVerEstadisticaFutbolista();
                    frm.Stat = Deportistas.Atletas[Deportistas.INDEX].Estadisticas[i];
                    Deportistas.MyAtleta = Deportistas.Atletas[Deportistas.INDEX];


                    frm.EnableDisabledTextBox(false);

                    frm.ShowDialog();

                }
            }else
                MessageBox.Show($"{Messages.SureSelectMessage("Estadistica")}", "Seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        protected override void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lvVisor.SelectedIndices.Count > 0)
            {
                // Obtén el índice del elemento seleccionado
                int i = lvVisor.SelectedIndices[0];

                IDeportista d = Deportistas.Atletas[Deportistas.INDEX];

                if (i >= 0 && i < d.Estadisticas.Count())
                {
                    // Obtener el atleta correspondiente al índice

                    IEstadistica stat = d.Estadisticas[i];
                    DialogResult res = MessageBox.Show($"{Messages.DoYouWantMessage("Estadistica")}\n {stat.Fecha} - {stat.Competicion}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (res == DialogResult.Yes)
                    {
                        d.Estadisticas.RemoveAt(i);
                        Serializer<Deportista>.JsonSerializerList(Deportistas.Atletas, Paths.DeportistasPath);
                        ActualizarVisor();

                        MessageBox.Show($"{Messages.CongratsDeleteMessage("Estadistica")}", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
                MessageBox.Show($"{Messages.SureSelectMessage("Estadistica")}", "Seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        protected override void btnModificar_Click(object sender, EventArgs e)
        {
            if (lvVisor.SelectedIndices.Count > 0)
            {
                // Obtén el índice del elemento seleccionado
                int i = lvVisor.SelectedIndices[0];

               

                if (i >= 0 && i < Deportistas.Atletas[Deportistas.INDEX].Estadisticas.Count())
                {
                    // Obtener el atleta correspondiente al índice

                    FrmCargarEstadisticas frm = new FrmCargarEstadisticaFutbolista();
                    frm.Stat = (IEstadisticaFutbolista)Deportistas.Atletas[Deportistas.INDEX].Estadisticas[i];
                    
                    frm.Indice = i;
                    frm.PrintDates();
                    frm.IsModifier = true;
                    
                    //DialogResult res = MessageBox.Show($"{Messages.DoYouWantMessage("Estadistica")}\n {stat.Fecha} - {stat.Competicion}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    this.Hide();
                    frm.ShowDialog();
                    frm.Close();

                    cmbDeporte.SelectedIndex = -1;
                    ActualizarVisor();
                    this.Show();
                }
            }
            else
                MessageBox.Show($"{Messages.SureSelectMessage("Estadistica")}", "Seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        protected override void cmbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (cmbOrder.SelectedIndex >= 0)
            {
               if( Enum.TryParse(cmbOrder.SelectedItem.ToString(), out EEstadisticas option))
                {
            
                    List<EFutbolista> list = new();

                    list = ConvertListToIFutbolista(Deportistas.Atletas[Deportistas.INDEX].Estadisticas);
                    list = list.OrderListBy(option);
                    Deportistas.Atletas[Deportistas.INDEX].Estadisticas.Clear();
                    Deportistas.Atletas[Deportistas.INDEX].Estadisticas.AddRange(list);
                   
                    ActualizarVisor();

                }
               //list.OrderBy(list,option);
        
            }
            
        }

        private List<EFutbolista> ConvertListToIFutbolista(List<Estadisticas> list)
        {
            List<EFutbolista> aux = new();
            foreach (var item in list)
            {
                if (item is EFutbolista e)
                    aux.Add(e);
            }

            return aux;

        }
        private void SetControlsAndVisor()
        {
            btnAgregar.Text = "Agregar Estadistica";
            btnVer.Text = "Ver Estadistica";
            btnCerrarSesion.Text = "Guardar";

            btnAgregar.Enabled = true;
            lbDateTime.Text = DateTime.Now.Date.ToShortDateString();
            lbDateTime.ForeColor = Color.Green;
            lbUser.Text = Usuarios.MyUser.NickName;
            cmbOrder.DataSource = Enum.GetValues(typeof(EEstadisticas));
            cmbOrder.SelectedIndex = -1;

            //Cargo los deportistas [Nombre - Deporte] en el visor.
            this.ActualizarVisor();
        }

    }
}
