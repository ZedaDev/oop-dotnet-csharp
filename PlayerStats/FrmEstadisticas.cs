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
            SetControls();
            if(Deportistas.MyAtleta.Estadisticas.Count <= 0)
            {
                AccesoDatos ac = new();
                ac.TraerEstadisticasDeportista(Deportistas.MyAtleta);
            }
            ActualizarVisor();
        }


        private  void ActualizarVisor()
        {
            lvVisor.Clear();
            lvVisor.Items.Clear();
            if(lvVisor.Items.Count <= 0)
            {
                List<Estadisticas> estadisticas = Deportistas.MyAtleta.Estadisticas;
                //estadisticas.ConvertAll(e => new EFutbolista());
                if (estadisticas is not null && estadisticas.Count > 0)
                {
                    foreach (Estadisticas v in estadisticas)
                    {
                        if (v is IEstadisticaFutbolista value)
                            lvVisor.Items.Add($"Vs {value.Rival} ({value.Fecha.ToShortDateString()}) | {value.Competicion} - Estadio {value.Estadio}");
                    }

                    lbVisorCargado.ForeColor = Color.Green;
                    lbVisorCargado.Text = $"Estadisticas Cargadas : {Deportistas.MyAtleta.Estadisticas.Count()}";
                }
                else
                {
                    lbVisorCargado.ForeColor = Color.Red;
                    lbVisorCargado.Text = "No hay estadisticas cargadas aun.";
                }
            }
          

        }

        protected override void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        protected override void btnVer_Click(object sender, EventArgs e)
        {
            Ver();
        }

        protected override void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
        protected override void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar();
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
        private void SetControls()
        {
            btnAgregar.Text = "Agregar Estadistica";
            btnVer.Text = "Ver Estadistica";
            btnCerrarSesion.Text = "Guardar";

            btnAgregar.Enabled = true;
            lbDateTime.Text = DateTime.Now.Date.ToShortDateString();
            lbDateTime.ForeColor = Color.Green;
            lbUser.Text = Deportistas.MyAtleta.FullName;
            cmbOrder.DataSource = Enum.GetValues(typeof(EEstadisticas));
            cmbOrder.SelectedIndex = -1;

            //Cargo los deportistas [Nombre - Deporte] en el visor.
            //this.ActualizarVisor();
        }

  
           
        private void Ver()
        {
            int i = CheckVisor(lvVisor);
                if (i < 0)
                    MessageBox.Show("Seleccione Una Estadistica", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {

                    FrmVerEstadistica frm = new FrmVerEstadisticaFutbolista();
                    frm.Stat = Deportistas.MyAtleta.Estadisticas[i];


                    frm.EnableDisabledTextBox(false);

                    frm.ShowDialog();

                    frm.Close();

                }
            
            
        }

        private void Agregar()
        {
            FrmCargarEstadisticas frm = new FrmCargarEstadisticaFutbolista();


            this.Hide();
            frm.IsModifier = false;

            frm.ShowDialog();

            ActualizarVisor();
            this.Show();
        }
        private void Eliminar()
        {
                // Obtén el índice del elemento seleccionado
                int i = CheckVisor(lvVisor);


                if (i >= 0 && i < Deportistas.MyAtleta.Estadisticas.Count())
                {
                    IDeportista d = Deportistas.MyAtleta;
                    // Obtener el atleta correspondiente al índice

                    //Solucion al agrear mas deportistas, hacer un switch y, castear la estadistica segun el deporte.
                    EFutbolista stat = (EFutbolista)d.Estadisticas[i];
                    DialogResult res = MessageBox.Show($"{Messages.DoYouWantMessage("Estadistica")}\n {stat.Fecha} - {stat.Competicion}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (res == DialogResult.Yes)
                    {
                        d.Estadisticas.RemoveAt(i);
                        Serializer<Deportista>.JsonSerializerList(Deportistas.Atletas, Paths.DeportistasPath);
                        AccesoDatos ac = new();
                        ac.UpdateDeleteEstadisticaFutbolista(stat, Usuarios.MyUser.Id, EOption.Eliminar);

                        ActualizarVisor();

                        MessageBox.Show($"{Messages.CongratsDeleteMessage("Estadistica")}", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                     MessageBox.Show($"{Messages.SureSelectMessage("Estadistica")}", "Seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void Modificar()
        {
            ///LOGICA AQUI DE ENVIAR ESTO A METODOS Y ESTOS METODOS EN ERIFICAR Y LUEGO LLAMAR A VERIFICARBTNMODIFICAR, ETC
            ///mediante un delegado que se atributo y se cargue como metodo .
          
                // Obtén el índice del elemento seleccionado
                int i = CheckVisor(lvVisor);
            



                if (i >= 0 && i < Deportistas.MyAtleta.Estadisticas.Count())
                {
                    // Obtener el atleta correspondiente al índice

                    FrmCargarEstadisticas frm = new FrmCargarEstadisticaFutbolista();
                    frm.Stat = Deportistas.MyAtleta.Estadisticas[i]; // Me guarda la estadistica


                    frm.Indice = i; //Me guarda el index de la estadistica
                    frm.PrintDates(); //Printea los datos, ya que es modificar.
                    frm.IsModifier = true; //Se settea para Modificar

                    //DialogResult res = MessageBox.Show($"{Messages.DoYouWantMessage("Estadistica")}\n {stat.Fecha} - {stat.Competicion}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    this.Hide();
                    frm.ShowDialog();
                    frm.Close();

                    cmbDeporte.SelectedIndex = -1;
                    ActualizarVisor();
                    this.Show();
                }
            else
                MessageBox.Show($"{Messages.SureSelectMessage("Estadistica")}", "Seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
