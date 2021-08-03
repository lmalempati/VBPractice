using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VBPractice;
namespace MyFormsApp
{
    public partial class MyFormControl : Form
    {
        public delegate void AddListItem();
        public AddListItem myDelegate;
        private Button myButton;
        private Thread myThread;
        private ListBox myListBox;
        public MyFormControl()
        {
            InitializeComponent();

            myButton = new Button();
            myListBox = new ListBox();
            myButton.Location = new Point(72, 160);
            myButton.Size = new Size(152, 32);
            myButton.TabIndex = 1;
            myButton.Text = "Add items in list box";
            myButton.Click += new EventHandler(button1_Click);
            myListBox.Location = new Point(48, 32);
            myListBox.Name = "myListBox";
            myListBox.Size = new Size(200, 95);
            myListBox.TabIndex = 2;
            ClientSize = new Size(292, 273);
            Controls.AddRange(new Control[] { myListBox, myButton });
            Text = " 'Control_Invoke' example";
            myDelegate = new AddListItem(AddListItemMethod);
            // Cannot do this - why?? saying this is called on separate thread than that created!!
            //var T = new Thread(new ThreadStart(AddListItemMethod));
            //T.Start();

        }
        //static void Main()
        //{
        //    MyFormControl myForm = new MyFormControl();
        //    myForm.ShowDialog();
        //}
        public void AddListItemMethod()
        {
            String myItem;
            for (int i = 1; i < 6; i++)
            {
                myItem = "MyListItem" + i.ToString();
                myListBox.Items.Add(myItem);
                myListBox.Update();
                Thread.Sleep(300);
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            this.Invoke(myDelegate);
            myThread = new Thread(new ThreadStart(ThreadFunction));
            myThread.Start();
        }
        private void ThreadFunction()
        {
            MyThreadClass myThreadClassObject = new MyThreadClass(this);
            myThreadClassObject.Run();
        }
        //public MyFormControl()
        //{
        //    InitializeComponent();
        //}

        private void button1_Click(object sender, EventArgs e)
        {
           MessageBox.Show(Math.Sqrt(int.Parse( tbNumber.Text)).ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string json = @"[
    {
      'xNACSProductCode': '001',
      'xUnitOfMeasure': 'G',
      'xQuantity': '01',
	  'xUnitPrice': '21023',
	  'xProductAmount':'1023'
    },
	{
      'xNACSProductCode': '101',
      'xUnitOfMeasure': 'G',
      'xQuantity': '02',
	  'xUnitPrice': '21023',
	  'xProductAmount':'1023'
    },
		{
      'xNACSProductCode': '400',
      'xUnitOfMeasure': 'G',
      'xQuantity': '03',
	  'xUnitPrice': '21023',
	  'xProductAmount':'1023'
    }
	]";
           dataGridView1.DataSource =  VBPractice.modSerialize.DeserializeJSON<List<modSerialize.NACSProductdtls>>(json);

        }
    }

    public class MyThreadClass
    {
        MyFormControl myFormControl1;
        public MyThreadClass(MyFormControl myForm)
        {
            myFormControl1 = myForm;
        }

        public void Run()
        {
            // Execute the specified delegate on the thread that owns
            // 'myFormControl1' control's underlying window handle.
            myFormControl1.Invoke(myFormControl1.myDelegate);
        }
    }
 }
