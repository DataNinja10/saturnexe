using CloudyApi;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
namespace Saturn
{
    public partial class Form1 : Form
    {
        // Instancia estática de Form1 (patrón Singleton)
        public static Form1 Instance { get; private set; }

        public Form1()
        {
            InitializeComponent();

            // Asignar la instancia de Form1
            Instance = this;
        }

        private void abcforfree2_Click(object sender, EventArgs e)
        {
            CloudyApi.Api.execute(rich.Text);
        }

        private void abcforfree1_Click(object sender, EventArgs e)
        {
            CloudyApi.Api.inject();
            MessageBox.Show("Injected! Now you can execute scripts", "Saturn", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            rich.Clear();

        }

        private void scripts_Click(object sender, EventArgs e)
        {
            Form2 nuevaVentana = new Form2();
            nuevaVentana.Show();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de texto y LUA|*.txt;*.lua";
                openFileDialog.Title = "Seleccionar un archivo";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        rich.Text = File.ReadAllText(openFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al leer el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void open_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de texto y LUA|*.txt;*.lua";
                openFileDialog.Title = "Seleccionar un archivo";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        rich.Text = File.ReadAllText(openFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al leer el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Archivos LUA (*.lua)|*.lua";
                saveFileDialog.Title = "Guardar archivo";
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.AddExtension = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllText(saveFileDialog.FileName, rich.Text);
                        MessageBox.Show("Code saved", "Code saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Code failed to save: " + ex.Message, "Code failed to save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void settings_Click(object sender, EventArgs e)
        {
            // Mostrar el primer MessageBox con tres opciones
            DialogResult result = MessageBox.Show("Do you want to active dark mode?", "Settings", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            // Si el usuario selecciona "Sí", cambiar el color de fondo
            if (result == DialogResult.Yes)
            {
                this.BackColor = System.Drawing.Color.Gray;
                rich.BackColor = System.Drawing.Color.DarkGray;
                settings.BackColor = System.Drawing.Color.Gray;
                save.BackColor = System.Drawing.Color.Gray;
                open.BackColor = System.Drawing.Color.Gray;
                scripts.BackColor = System.Drawing.Color.Gray;
                clear.BackColor = System.Drawing.Color.Gray;
                abcforfree2.BackColor = System.Drawing.Color.Gray;
                abcforfree1.BackColor = System.Drawing.Color.Gray;



            }
            if (result == DialogResult.Cancel)
            {
                return;
            }

            // Si el usuario selecciona "Cancelar", mostrar otro MessageBox con dos opciones
            if (result == DialogResult.No)
            {
                // Mostrar un segundo MessageBox con opciones "Cerrar" y una adicional
                DialogResult secondResult = MessageBox.Show("Active auto inject?", "Saturn", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                // Si el usuario selecciona "Sí" en el segundo MessageBox, cerrar el formulario
                if (secondResult == DialogResult.Yes)
                {
                    Api.AutoInject(Enabled);
                }
                // Si el usuario selecciona "No" en el segundo MessageBox, hacer nada
                else if (secondResult == DialogResult.No)
                {
                    return;
                }

            }
            // Si el usuario selecciona "No", no hacer nada
            else if (result == DialogResult.No)
            {
                // No hacer nada
            }
        }

        private void rich_TextChanged(object sender, EventArgs e)
        {

        }
    }
}














