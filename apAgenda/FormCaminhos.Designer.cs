namespace apCaminhos
{
    partial class FormCaminhos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCaminhos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.mesagemStatusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.imlBotoes = new System.Windows.Forms.ImageList(this.components);
            this.Caminhos = new System.Windows.Forms.ToolStrip();
            this.inicioToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.anteriorToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.proximoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ultimoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.procurarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.novoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cancelarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.salvarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.excluirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cidadesOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mapaPictureBox = new System.Windows.Forms.PictureBox();
            this.caminhosEncontradosLabel = new System.Windows.Forms.Label();
            this.melhorCaminhoLabel = new System.Windows.Forms.Label();
            this.caminhosEncontradosDataGridView = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.melhorCaminhoDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acharCaminhosButton = new System.Windows.Forms.Button();
            this.custoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tempoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.distanciaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.custoLabel = new System.Windows.Forms.Label();
            this.tempoLabel = new System.Windows.Forms.Label();
            this.distanciaLabel = new System.Windows.Forms.Label();
            this.destinoLabel = new System.Windows.Forms.Label();
            this.origemLabel = new System.Windows.Forms.Label();
            this.destinoComboBox = new System.Windows.Forms.ComboBox();
            this.origemComboBox = new System.Windows.Forms.ComboBox();
            this.kmCaminhoSelecionadoLabel = new System.Windows.Forms.Label();
            this.caminhosOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip.SuspendLayout();
            this.Caminhos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caminhosEncontradosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.melhorCaminhoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanciaNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mesagemStatusStripLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 730);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1336, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // mesagemStatusStripLabel
            // 
            this.mesagemStatusStripLabel.Name = "mesagemStatusStripLabel";
            this.mesagemStatusStripLabel.Size = new System.Drawing.Size(76, 17);
            this.mesagemStatusStripLabel.Text = "Registro 1/23";
            // 
            // imlBotoes
            // 
            this.imlBotoes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlBotoes.ImageStream")));
            this.imlBotoes.TransparentColor = System.Drawing.Color.Transparent;
            this.imlBotoes.Images.SetKeyName(0, "first.bmp");
            this.imlBotoes.Images.SetKeyName(1, "prior.bmp");
            this.imlBotoes.Images.SetKeyName(2, "next.bmp");
            this.imlBotoes.Images.SetKeyName(3, "last.bmp");
            this.imlBotoes.Images.SetKeyName(4, "Oeil2.bmp");
            this.imlBotoes.Images.SetKeyName(5, "Add.bmp");
            this.imlBotoes.Images.SetKeyName(6, "UNDO.BMP");
            this.imlBotoes.Images.SetKeyName(7, "Save.bmp");
            this.imlBotoes.Images.SetKeyName(8, "Minus.bmp");
            this.imlBotoes.Images.SetKeyName(9, "CLOSE1.BMP");
            // 
            // Caminhos
            // 
            this.Caminhos.BackColor = System.Drawing.Color.Silver;
            this.Caminhos.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Caminhos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripButton,
            this.anteriorToolStripButton,
            this.proximoToolStripButton,
            this.ultimoToolStripButton,
            this.toolStripSeparator1,
            this.procurarToolStripButton,
            this.toolStripSeparator3,
            this.novoToolStripButton,
            this.cancelarToolStripButton,
            this.salvarToolStripButton,
            this.toolStripSeparator2,
            this.toolStripSeparator4,
            this.excluirToolStripButton,
            this.toolStripSeparator5,
            this.sairToolStripButton});
            this.Caminhos.Location = new System.Drawing.Point(0, 0);
            this.Caminhos.Name = "Caminhos";
            this.Caminhos.Size = new System.Drawing.Size(1336, 42);
            this.Caminhos.TabIndex = 3;
            this.Caminhos.Text = "toolStrip";
            // 
            // inicioToolStripButton
            // 
            this.inicioToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("inicioToolStripButton.Image")));
            this.inicioToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.inicioToolStripButton.Name = "inicioToolStripButton";
            this.inicioToolStripButton.Size = new System.Drawing.Size(40, 39);
            this.inicioToolStripButton.Text = "Início";
            this.inicioToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // anteriorToolStripButton
            // 
            this.anteriorToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("anteriorToolStripButton.Image")));
            this.anteriorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.anteriorToolStripButton.Name = "anteriorToolStripButton";
            this.anteriorToolStripButton.Size = new System.Drawing.Size(54, 39);
            this.anteriorToolStripButton.Text = "Anterior";
            this.anteriorToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // proximoToolStripButton
            // 
            this.proximoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("proximoToolStripButton.Image")));
            this.proximoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.proximoToolStripButton.Name = "proximoToolStripButton";
            this.proximoToolStripButton.Size = new System.Drawing.Size(56, 39);
            this.proximoToolStripButton.Text = "Próximo";
            this.proximoToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ultimoToolStripButton
            // 
            this.ultimoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ultimoToolStripButton.Image")));
            this.ultimoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ultimoToolStripButton.Name = "ultimoToolStripButton";
            this.ultimoToolStripButton.Size = new System.Drawing.Size(47, 39);
            this.ultimoToolStripButton.Text = "Último";
            this.ultimoToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // procurarToolStripButton
            // 
            this.procurarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("procurarToolStripButton.Image")));
            this.procurarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.procurarToolStripButton.Name = "procurarToolStripButton";
            this.procurarToolStripButton.Size = new System.Drawing.Size(56, 39);
            this.procurarToolStripButton.Text = "Procurar";
            this.procurarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 42);
            // 
            // novoToolStripButton
            // 
            this.novoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("novoToolStripButton.Image")));
            this.novoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.novoToolStripButton.Name = "novoToolStripButton";
            this.novoToolStripButton.Size = new System.Drawing.Size(40, 39);
            this.novoToolStripButton.Text = "Novo";
            this.novoToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // cancelarToolStripButton
            // 
            this.cancelarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelarToolStripButton.Image")));
            this.cancelarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelarToolStripButton.Name = "cancelarToolStripButton";
            this.cancelarToolStripButton.Size = new System.Drawing.Size(57, 39);
            this.cancelarToolStripButton.Text = "Cancelar";
            this.cancelarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // salvarToolStripButton
            // 
            this.salvarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripButton.Image")));
            this.salvarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvarToolStripButton.Name = "salvarToolStripButton";
            this.salvarToolStripButton.Size = new System.Drawing.Size(42, 39);
            this.salvarToolStripButton.Text = "Salvar";
            this.salvarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 42);
            // 
            // excluirToolStripButton
            // 
            this.excluirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("excluirToolStripButton.Image")));
            this.excluirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.excluirToolStripButton.Name = "excluirToolStripButton";
            this.excluirToolStripButton.Size = new System.Drawing.Size(46, 39);
            this.excluirToolStripButton.Text = "Excluir";
            this.excluirToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 42);
            // 
            // sairToolStripButton
            // 
            this.sairToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("sairToolStripButton.Image")));
            this.sairToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sairToolStripButton.Name = "sairToolStripButton";
            this.sairToolStripButton.Size = new System.Drawing.Size(30, 39);
            this.sairToolStripButton.Text = "Sair";
            this.sairToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // cidadesOpenFileDialog
            // 
            this.cidadesOpenFileDialog.DefaultExt = "*.txt";
            this.cidadesOpenFileDialog.InitialDirectory = "c:\\temp";
            // 
            // mapaPictureBox
            // 
            this.mapaPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapaPictureBox.ErrorImage = null;
            this.mapaPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("mapaPictureBox.Image")));
            this.mapaPictureBox.InitialImage = null;
            this.mapaPictureBox.Location = new System.Drawing.Point(332, 45);
            this.mapaPictureBox.Name = "mapaPictureBox";
            this.mapaPictureBox.Size = new System.Drawing.Size(1001, 548);
            this.mapaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mapaPictureBox.TabIndex = 10;
            this.mapaPictureBox.TabStop = false;
            this.mapaPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.mapaPictureBox_Paint);
            // 
            // caminhosEncontradosLabel
            // 
            this.caminhosEncontradosLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.caminhosEncontradosLabel.AutoSize = true;
            this.caminhosEncontradosLabel.Location = new System.Drawing.Point(12, 576);
            this.caminhosEncontradosLabel.Name = "caminhosEncontradosLabel";
            this.caminhosEncontradosLabel.Size = new System.Drawing.Size(173, 20);
            this.caminhosEncontradosLabel.TabIndex = 32;
            this.caminhosEncontradosLabel.Text = "Caminhos encontrados";
            // 
            // melhorCaminhoLabel
            // 
            this.melhorCaminhoLabel.AutoSize = true;
            this.melhorCaminhoLabel.Location = new System.Drawing.Point(121, 190);
            this.melhorCaminhoLabel.Name = "melhorCaminhoLabel";
            this.melhorCaminhoLabel.Size = new System.Drawing.Size(195, 20);
            this.melhorCaminhoLabel.TabIndex = 33;
            this.melhorCaminhoLabel.Text = "Melhor caminho (yyyyy km)";
            // 
            // caminhosEncontradosDataGridView
            // 
            this.caminhosEncontradosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.caminhosEncontradosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.caminhosEncontradosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.caminhosEncontradosDataGridView.Location = new System.Drawing.Point(10, 599);
            this.caminhosEncontradosDataGridView.Name = "caminhosEncontradosDataGridView";
            this.caminhosEncontradosDataGridView.Size = new System.Drawing.Size(1323, 121);
            this.caminhosEncontradosDataGridView.TabIndex = 32;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "1a";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "2a";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "3a";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "4a";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "5a";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "6a";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "7a";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "8a";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "9a";
            this.Column10.Name = "Column10";
            // 
            // melhorCaminhoDataGridView
            // 
            this.melhorCaminhoDataGridView.AllowUserToDeleteRows = false;
            this.melhorCaminhoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.melhorCaminhoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.melhorCaminhoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.melhorCaminhoDataGridView.Location = new System.Drawing.Point(120, 213);
            this.melhorCaminhoDataGridView.Name = "melhorCaminhoDataGridView";
            this.melhorCaminhoDataGridView.Size = new System.Drawing.Size(201, 326);
            this.melhorCaminhoDataGridView.TabIndex = 33;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Passando por";
            this.Column1.Name = "Column1";
            this.Column1.Width = 132;
            // 
            // acharCaminhosButton
            // 
            this.acharCaminhosButton.Location = new System.Drawing.Point(10, 213);
            this.acharCaminhosButton.Name = "acharCaminhosButton";
            this.acharCaminhosButton.Size = new System.Drawing.Size(104, 63);
            this.acharCaminhosButton.TabIndex = 45;
            this.acharCaminhosButton.Text = "Achar caminhos";
            this.acharCaminhosButton.UseVisualStyleBackColor = true;
            this.acharCaminhosButton.Click += new System.EventHandler(this.acharCaminhosButton_Click);
            // 
            // custoNumericUpDown
            // 
            this.custoNumericUpDown.Location = new System.Drawing.Point(85, 148);
            this.custoNumericUpDown.Name = "custoNumericUpDown";
            this.custoNumericUpDown.Size = new System.Drawing.Size(74, 26);
            this.custoNumericUpDown.TabIndex = 44;
            // 
            // tempoNumericUpDown
            // 
            this.tempoNumericUpDown.Location = new System.Drawing.Point(227, 116);
            this.tempoNumericUpDown.Name = "tempoNumericUpDown";
            this.tempoNumericUpDown.Size = new System.Drawing.Size(74, 26);
            this.tempoNumericUpDown.TabIndex = 43;
            // 
            // distanciaNumericUpDown
            // 
            this.distanciaNumericUpDown.Location = new System.Drawing.Point(85, 116);
            this.distanciaNumericUpDown.Maximum = new decimal(new int[] {
            12500,
            0,
            0,
            0});
            this.distanciaNumericUpDown.Name = "distanciaNumericUpDown";
            this.distanciaNumericUpDown.Size = new System.Drawing.Size(74, 26);
            this.distanciaNumericUpDown.TabIndex = 42;
            // 
            // custoLabel
            // 
            this.custoLabel.AutoSize = true;
            this.custoLabel.Location = new System.Drawing.Point(6, 150);
            this.custoLabel.Name = "custoLabel";
            this.custoLabel.Size = new System.Drawing.Size(55, 20);
            this.custoLabel.TabIndex = 41;
            this.custoLabel.Text = "Custo:";
            // 
            // tempoLabel
            // 
            this.tempoLabel.AutoSize = true;
            this.tempoLabel.Location = new System.Drawing.Point(167, 118);
            this.tempoLabel.Name = "tempoLabel";
            this.tempoLabel.Size = new System.Drawing.Size(62, 20);
            this.tempoLabel.TabIndex = 40;
            this.tempoLabel.Text = "Tempo:";
            // 
            // distanciaLabel
            // 
            this.distanciaLabel.AutoSize = true;
            this.distanciaLabel.Location = new System.Drawing.Point(6, 118);
            this.distanciaLabel.Name = "distanciaLabel";
            this.distanciaLabel.Size = new System.Drawing.Size(79, 20);
            this.distanciaLabel.TabIndex = 39;
            this.distanciaLabel.Text = "Distância:";
            // 
            // destinoLabel
            // 
            this.destinoLabel.AutoSize = true;
            this.destinoLabel.Location = new System.Drawing.Point(164, 54);
            this.destinoLabel.Name = "destinoLabel";
            this.destinoLabel.Size = new System.Drawing.Size(68, 20);
            this.destinoLabel.TabIndex = 38;
            this.destinoLabel.Text = "Destino:";
            // 
            // origemLabel
            // 
            this.origemLabel.AutoSize = true;
            this.origemLabel.Location = new System.Drawing.Point(6, 53);
            this.origemLabel.Name = "origemLabel";
            this.origemLabel.Size = new System.Drawing.Size(64, 20);
            this.origemLabel.TabIndex = 37;
            this.origemLabel.Text = "Origem:";
            // 
            // destinoComboBox
            // 
            this.destinoComboBox.FormattingEnabled = true;
            this.destinoComboBox.Location = new System.Drawing.Point(171, 76);
            this.destinoComboBox.Name = "destinoComboBox";
            this.destinoComboBox.Size = new System.Drawing.Size(150, 28);
            this.destinoComboBox.TabIndex = 36;
            this.destinoComboBox.SelectedIndexChanged += new System.EventHandler(this.destinoComboBox_SelectedIndexChanged);
            // 
            // origemComboBox
            // 
            this.origemComboBox.FormattingEnabled = true;
            this.origemComboBox.Items.AddRange(new object[] {
            "123456789012345"});
            this.origemComboBox.Location = new System.Drawing.Point(10, 76);
            this.origemComboBox.Name = "origemComboBox";
            this.origemComboBox.Size = new System.Drawing.Size(150, 28);
            this.origemComboBox.TabIndex = 35;
            this.origemComboBox.SelectedIndexChanged += new System.EventHandler(this.origemComboBox_SelectedIndexChanged);
            // 
            // kmCaminhoSelecionadoLabel
            // 
            this.kmCaminhoSelecionadoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kmCaminhoSelecionadoLabel.AutoSize = true;
            this.kmCaminhoSelecionadoLabel.Location = new System.Drawing.Point(12, 556);
            this.kmCaminhoSelecionadoLabel.Name = "kmCaminhoSelecionadoLabel";
            this.kmCaminhoSelecionadoLabel.Size = new System.Drawing.Size(285, 20);
            this.kmCaminhoSelecionadoLabel.TabIndex = 48;
            this.kmCaminhoSelecionadoLabel.Text = "Km do caminho selecionado: (xxxxx km)";
            // 
            // caminhosOpenFileDialog
            // 
            this.caminhosOpenFileDialog.DefaultExt = "*.txt";
            this.caminhosOpenFileDialog.InitialDirectory = "c:\\temp";
            // 
            // FormCaminhos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 752);
            this.Controls.Add(this.kmCaminhoSelecionadoLabel);
            this.Controls.Add(this.caminhosEncontradosLabel);
            this.Controls.Add(this.melhorCaminhoLabel);
            this.Controls.Add(this.acharCaminhosButton);
            this.Controls.Add(this.custoNumericUpDown);
            this.Controls.Add(this.tempoNumericUpDown);
            this.Controls.Add(this.distanciaNumericUpDown);
            this.Controls.Add(this.custoLabel);
            this.Controls.Add(this.tempoLabel);
            this.Controls.Add(this.distanciaLabel);
            this.Controls.Add(this.destinoLabel);
            this.Controls.Add(this.origemLabel);
            this.Controls.Add(this.destinoComboBox);
            this.Controls.Add(this.origemComboBox);
            this.Controls.Add(this.melhorCaminhoDataGridView);
            this.Controls.Add(this.caminhosEncontradosDataGridView);
            this.Controls.Add(this.mapaPictureBox);
            this.Controls.Add(this.Caminhos);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormCaminhos";
            this.Text = "Ligações e caminhos entre Cidades";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCaminhos_FormClosing);
            this.Load += new System.EventHandler(this.FrmAgenda_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.Caminhos.ResumeLayout(false);
            this.Caminhos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caminhosEncontradosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.melhorCaminhoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanciaNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ImageList imlBotoes;
        private System.Windows.Forms.ToolStrip Caminhos;
        private System.Windows.Forms.ToolStripButton inicioToolStripButton;
        private System.Windows.Forms.ToolStripButton anteriorToolStripButton;
        private System.Windows.Forms.ToolStripButton proximoToolStripButton;
        private System.Windows.Forms.ToolStripButton ultimoToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton procurarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton novoToolStripButton;
        private System.Windows.Forms.ToolStripButton cancelarToolStripButton;
        private System.Windows.Forms.ToolStripButton salvarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton excluirToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton sairToolStripButton;
        private System.Windows.Forms.OpenFileDialog cidadesOpenFileDialog;
        private System.Windows.Forms.ToolStripStatusLabel mesagemStatusStripLabel;
        private System.Windows.Forms.PictureBox mapaPictureBox;
        private System.Windows.Forms.Label melhorCaminhoLabel;
        private System.Windows.Forms.Label caminhosEncontradosLabel;
        private System.Windows.Forms.DataGridView caminhosEncontradosDataGridView;
        private System.Windows.Forms.DataGridView melhorCaminhoDataGridView;
        private System.Windows.Forms.Button acharCaminhosButton;
        private System.Windows.Forms.NumericUpDown custoNumericUpDown;
        private System.Windows.Forms.NumericUpDown tempoNumericUpDown;
        private System.Windows.Forms.NumericUpDown distanciaNumericUpDown;
        private System.Windows.Forms.Label custoLabel;
        private System.Windows.Forms.Label tempoLabel;
        private System.Windows.Forms.Label distanciaLabel;
        private System.Windows.Forms.Label destinoLabel;
        private System.Windows.Forms.Label origemLabel;
        private System.Windows.Forms.ComboBox destinoComboBox;
        private System.Windows.Forms.ComboBox origemComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label kmCaminhoSelecionadoLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.OpenFileDialog caminhosOpenFileDialog;
    }
}

