using SPSA.RetoCliente.BusinessComponent.Interface;
using SPSA.RetoCliente.BusinessComponent.Interface.Factory;
using SPSA.RetoCliente.BusinessEntities;
using System;
using System.Windows.Forms;

namespace SPSA.RetoCliente.Forms
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.CustomFormat = "yyyy/MM/dd";
            dgvClients.DataSource = _ClientsBindingSource;
        }
        private void frmCliente_Load(object sender, EventArgs e)
        {
            RefreshData();
            dgvClients.AutoResizeColumns();
        }

        private void RefreshData()
        {
            ReloadClients();
            var kpi = GetKPI();

            _ClientsBindingSource.DataSource = clientes;
            lblStandardDesviationValue.Text = kpi.StandardDeviation.ToString("0.00");
            lblAverageValue.Text = kpi.Average.ToString("0.00");
        }

        private void ReloadClients()
        {
            clientes = BCClient.Value.GetClients((int)nudEdadMuerte.Value);
        }

        private KPIResult GetKPI()
            => BCClient.Value.GetKPIResult();

        private readonly BindingSource _ClientsBindingSource = new BindingSource();

        private Client[] clientes = new Client[] { };

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                BCClient.Value.Submit(new ClientSubmit
                { Names = txtNames.Text, LastNames = txtLastNames.Text, BirthDay = dtpBirthDate.Value });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            RefreshData();
        }

        private readonly BusinessComponentClass<IBCClient> BCClient = new BusinessComponentClass<IBCClient>();

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}