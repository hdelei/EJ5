using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace MaterialSkinExample
{
    public partial class MainForm : MaterialForm
    {
        string[][] data;
        private readonly MaterialSkinManager materialSkinManager;
        public MainForm()
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red600, Primary.Red700, Primary.Red200, Accent.Red100, TextShade.WHITE);

            // Add dummy data to the listview
            data = new[]
            {
                new []{"123456789", "111111111", "MG", "100"},
                new []{"123456789", "111111111", "MG", "200"},
                new []{"121212121", "222222222", "SP", "300"},
                new []{"102019100", "555555555", "MT", "10"},
                new []{"098765432", "666666666", "RS", "2000"}
            };
            seedListView();
            
            datePickerInit();            

            
        }

	    private void seedListView()
	    {
			//Define
			//var data = new[]
	  //      {
		 //       new []{"123456789", "111111111", "MG", "100"},
			//	new []{"123456789", "111111111", "MG", "200"},
			//	new []{"121212121", "222222222", "SP", "300"},
			//	new []{"102019100", "555555555", "MT", "10"},
			//	new []{"098765432", "666666666", "RS", "2000"}
	  //      };

			//Add
			foreach (string[] version in data)
			{
				var item = new ListViewItem(version);
				materialListView2.Items.Add(item);
			}
	    }

        //private void materialButton1_Click(object sender, EventArgs e)
        //{
        //    materialSkinManager.Theme = materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
        //}

        //private int colorSchemeIndex;
   //     private void materialRaisedButton1_Click(object sender, EventArgs e)
   //     {
	  //      colorSchemeIndex++;
	  //      if (colorSchemeIndex > 2) colorSchemeIndex = 0;

			////These are just example color schemes
	  //      switch (colorSchemeIndex)
	  //      {
			//	case 0:
			//		materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
			//        break;
			//	case 1:
			//		materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
			//        break;
			//	case 2:
			//		materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);
			//		break;
	  //      }
   //     }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            
            //materialProgressBar1.Value = Math.Min(materialProgressBar1.Value + 10, 100);
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            //materialProgressBar1.Value = Math.Max(materialProgressBar1.Value - 10, 0);
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void datePickerInit()
        {
            dtInicial.Format = DateTimePickerFormat.Custom;
            dtInicial.CustomFormat = "dd/MM/yyyy";
            dtFinal.Format = DateTimePickerFormat.Custom;
            dtFinal.CustomFormat = "dd/MM/yyyy";
            dtInicial.Value = DateTime.Today.AddDays(-1);
        }

        private void cnpjDestino_SizeChanged(object sender, EventArgs e)
        {
            Console.WriteLine(cnpjOrigem.Width);
            Console.WriteLine(cnpjOrigem.Height);
            Console.WriteLine(cnpjOrigem.Location);
            
        }

        private void ResizeListViewColumns()
        {
            foreach (ColumnHeader column in materialListView1.Columns)
            {
                column.Width = -2;
            }
        }

        private void ResizeInsights()
        {
            foreach (ColumnHeader column in materialListView2.Columns)
            {
                column.Width = -2;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ResizeListViewColumns();

            //Sql sql = new Sql();

            //var teste = sql.CustomSelect("SELECT cib FROM Rastreabilidade;");

            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
