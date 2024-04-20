using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio01
{
    public partial class FrmProcesador : Form
    {

        private readonly IFileRepository _fileRepository;
        private readonly TextProcessor _textProcessor;
        public FrmProcesador()
        {
            InitializeComponent();
            _fileRepository = new FileRepository();
            _textProcessor = new TextProcessor();

        }

        private async void btnProcesador_Click(object sender, EventArgs e)
        {

            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Archivos de texto(*.txt)|*.txt|Todos los archivos de texto(*.*)|*.*";
                    openFileDialog.RestoreDirectory = true;


                    if(openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = openFileDialog.FileName;
                        string text = await _fileRepository.ReadFileAsync(filePath);
                        string processedText = _textProcessor.ConvertToUpperCase(text);

                        await _fileRepository.WriteFileAsync(filePath, processedText);

                        MessageBox.Show("Procesamiento del archivo completado con exito");
                    }
                }


              
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
            }



        }
    }
}
