namespace Laba {
    public partial class Form1 : Form {                                                             //����� ����� (����) ������������
        private List<Triangle> fractal;                                                             //������ �������������, �� ������� ������� �������
        private byte Step;                                                                          //����� ���� ����������
        private Bitmap back_buff;                                                                   //�������� ����������� ��� ��������� �������������
        public Form1() {                                                                            //����������� ����� (����)
            InitializeComponent();                                                                  //��������� ����������
            fractal = new();                                                                        //����-�� ������ �������������
            Step = 0;                                                                               //��������� ��� = 0
            StepShow.Text = $"��� ����� {Step}";                                                    //����� ����
            back_buff = new(FractalPlace.Width, FractalPlace.Height);                               //����-�� ������ ���������
        }
        private void ShowTriangles() {                                                              //������� ��������� ������������� � ������
            using (var art = Graphics.FromImage(back_buff)) {                                       //��������� ������� �� ���� ������
                art.Clear(Color.White);                                                             //������� ��� �����
                fractal.ForEach(t => t.Draw(in art, Convert.ToByte(changeScale.Value)));            //������ ������ �����������
            }                                                                                       //������������ �������
        }
        private void next_Click(object sender, EventArgs e) {                                       //��������� ���������� ����
            Step++;                                                                                 //��������� ������
            StepShow.Text = $"��� ����� {Step}";                                                    //����� ������
            List<Triangle> buff = new List<Triangle>();                                             //����� �������������
            foreach (var t in fractal)                                                              //��� ������� ������������� ������������
                buff.AddRange(t.Separate());                                                        //�������� ����� ������� ��� �� 6 ����� � ���������� �� � �����
            fractal = buff;                                                                         //��������� ������� �������
        }
        private void FractalPlace_Paint(object sender, PaintEventArgs e) {                          //��������� �������� � ����
            ShowTriangles();                                                                        //������������ ������� � ������
            e.Graphics.Clear(Color.White);                                                          //������� ������
            e.Graphics.DrawImage(back_buff, 0, 0);                                                  //������� �����
        }
        private void save_Click(object sender, EventArgs e) {                                       //���������� �����������
            SaveFileDialog dialog = new();                                                          //����� ������ ����������
            dialog.Title = "��������� �������...";                                                  //��������� �������
            dialog.OverwritePrompt = true;                                                          //������ �������������� � ������� ���������� ���-� ������ ��������
            dialog.Filter = "Image Files(*.JPG)|*.JPG";                                             //��������� �������
            if (dialog.ShowDialog() == DialogResult.OK) {                                           //���� ����������� �� ����������
                using (var file = File.Create(dialog.FileName)) {                                   //��������� ���� �������� �����
                    var s = Convert.ToByte(changeScale.Value);                                      //����� �������
                    var img = back_buff.Clone(new(0, 0, 400 * s, 400 * s), back_buff.PixelFormat);  //�������� ����� ������� ���� � ���������
                    img.Save(file, System.Drawing.Imaging.ImageFormat.Jpeg);                        //���������
                    img.Dispose();                                                                  //����������� ��������
                }                                                                                   //����������� ����
            }
        }

        private void Form1_Load(object sender, EventArgs e) {                                       //����� �������� �����
            var prepare = new PrepareForm();                                                        //������ ������
            do {
                prepare.ShowDialog();                                                               //����������
                if (prepare.DialogResult != DialogResult.OK)
                    MessageBox.Show("�������������� ����������� ����������� �����", "Error",        //����������� �� ������ ������� �����-��
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            } while (prepare.DialogResult != DialogResult.OK);                                      //���� �� ������� ��������� �����-�
            fractal.Add(prepare.Triangle);                                                          //����� ��������� �����. �������, �� ������� ��� �����������
        }
    }
}