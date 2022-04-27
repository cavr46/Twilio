using Newtonsoft.Json;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using TwilioApp.Models;

namespace TwilioApp
{
    public partial class Send : Form
    {
        string fileContent = string.Empty;
        string filePath = string.Empty;
        string accountSid = "ColocaTuSidAca";

        string authToken = "ColocaTuTokenAca";

        public Send()
        {
            InitializeComponent(); 
        }

        private void load_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "JSON files (*.JSON)|*.JSON|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    var fileStream = openFileDialog.OpenFile();
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            if (fileContent.Length > 0)
                list.Text = fileContent;
        }

        private void sendSMS_Click(object sender, EventArgs e)
        {
            bool validate = true;

            if (list.Text == string.Empty)
                validate  = false;
            if (message.Text == string.Empty)
                validate = false;

            if (!validate)
                MessageBox.Show("Error de validación", "Error", MessageBoxButtons.OK);
            else
            {
                List<DataItem> list = JsonConvert.DeserializeObject<List<DataItem>>(fileContent);
                TwilioClient.Init(accountSid, authToken);
                disable();

                foreach (var item in list)
                {
                    var SendMessage = MessageResource.Create(
                        body: $"{item.Name}: {message.Text}",
                        from: new Twilio.Types.PhoneNumber("+19378264451"),
                        to: new Twilio.Types.PhoneNumber(item.Phone)
                    );

                    responseTXT.Text = SendMessage.Sid;
                }

                enable();
                MessageBox.Show("Mensajes enviados", "Listo!", MessageBoxButtons.OK);
            }
        }

        private void disable()
        {
            load.Enabled = false;
            sendSMS.Enabled = false;
            loading.Visible = true;
            responseLabel.Visible = true;
            responseTXT.Visible = true;
        }

        private void enable()
        {
            loading.Visible = false;
            load.Enabled = true;
            sendSMS.Enabled = true;
            responseLabel.Visible = false;
            responseTXT.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}