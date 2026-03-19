using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using DocumentCore;

namespace DocumentApp
{
    public partial class Form1 : Form
    {
        private DocumentBuilder _builder = new DocumentBuilder();
        //установка  элементов управлени€ 
        private Button btnAddHeader;
        private Button btnAddText;
        private Button btnRemove;
        private Button btnBuild;
        private ListBox listBlocks;
        private RichTextBox txtResult;

        public Form1()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            //настройка формы
            this.Text = "конструктор формы";
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            //кнопка добавить заголовок
            btnAddHeader = new Button();
            btnAddHeader.Text = "добавить заголовок";
            btnAddHeader.Location = new Point(20, 60);
            btnAddHeader.Size = new Size(150, 30);
            btnAddHeader.Click += BtnAddHeader_Click;

            //кнопка добавить текст
            btnAddText = new Button();
            btnAddText.Text = "добавить текст";
            btnAddText.Location = new Point(20, 60);
            btnAddText.Size = new Size(150, 30);
            btnAddText.Click += BtnAddText_Click;

            //кнопка удалить выбрваннной
            btnRemove = new Button();
            btnRemove.Text = "добавить текст";
            btnRemove.Location = new Point(20, 60);
            btnRemove.Size = new Size(150, 30);
            btnRemove.Click += BtnRemove_Click;

            //кнопка собрать отчет
            btnBuild = new Button();
            btnBuild.Text = "добавить текст";
            btnBuild.Location = new Point(20, 60);
            btnBuild.Size = new Size(150, 30);
            btnBuild.Click += BtnBuild_Click;

            //кнопка добавить текст
            btnAddText = new Button();
            btnAddText.Text = "добавить текст";
            btnAddText.Location = new Point(20, 60);
            btnAddText.Size = new Size(150, 30);
            btnAddText.Click += BtnAddText_Click;

            //список блоков
            listBlocks = new ListBox();
            listBlocks.Location = new Point(200, 20);
            listBlocks.Size = new Size(250, 400);

            //поле с результатами
            txtResult = new RichTextBox();
            txtResult.Location = new Point(470, 20);
            txtResult.Size = new Size(300, 530);
            txtResult.ReadOnly = true;

            //добав€лем елементы на форму
            this.Controls.Add(btnAddHeader);
            this.Controls.Add(btnAddText);
            this.Controls.Add(btnRemove);
            this.Controls.Add(btnBuild);
            this.Controls.Add(listBlocks);
            this.Controls.Add(txtResult);
        }

        private void BtnBuild_Click(object? sender, EventArgs e)
        {
            string result = _builder.Build();
            txtResult.Text = result;

            block.SetContent("обычный текст документа");
            _builder.addBlock(block);
        }

        private void BtnRemove_Click(object? sender, EventArgs e)
        {
           if (listBlocks.SelectedIndex != -1)
            {
                _builder.removeBlock(listBlocks.SelectedIndex);
            }
        }

        private void BtnAddText_Click(object? sender, EventArgs e)
        {
            IBlock block = new HeaderBlock();
            block.SetContent("обычный текст документа");
            _builder.addBlock(block);
        }
        

        private void BtnAddHeader_Click(object? sender, EventArgs e)
        {
            IBlock block = new HeaderBlock();
            block.SetContent("Ќовый заголовок");
            _builder.addBlock(block);
        }



        }

    }


