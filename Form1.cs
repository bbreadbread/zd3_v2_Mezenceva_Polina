using zd3_v2_Mezenceva_Polina;

namespace zd3_v1_Mezenceva_Polina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxP.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSearchType.DropDownStyle = ComboBoxStyle.DropDownList;
            dataGridViewRoadWorks.AutoGenerateColumns = true; // Позволяем автоматическую генерацию столбцов
        }
        private void UpdateDataGridView()
        {
            dataGridViewRoadWorks.DataSource = null; // Сбрасываем источник данных
            dataGridViewRoadWorks.DataSource = CoefOfSafety.roadList; // Устанавливаем новый источник данных
        }
        private void loadButton_Click(object sender, EventArgs e)
        {
            if (!(textBoxWidth.Text == "" || textBoxLength.Text == "" || textBoxRoadMass.Text == "" ||
                textBoxLocation.Text == "" || comboBoxType.Text == "" || comboBoxP.Text == ""))
            {
                if (double.TryParse(textBoxWidth.Text, out double width) && double.TryParse(textBoxLength.Text, out double length) &&
                   double.TryParse(textBoxRoadMass.Text, out double roadMass) && double.TryParse(comboBoxP.Text, out double p) &&
                   int.TryParse(textBoxYear.Text, out int year) && int.TryParse(textBoxTraffic.Text, out int traf))
                {
                    if (width > 0 && length > 0 && roadMass > 0 && p >= 0 && traf > 0)
                    {
                        string location = textBoxLocation.Text;
                        string type = comboBoxType.Text;
                        string years = year.ToString();
                        string serviceLife = textBoxServiceLife.Text;

                        // Создание экземпляра CoefOfSafety и добавление в список
                        CoefOfSafety roadwork = new CoefOfSafety(width, length, roadMass, location, type, p, years, traf, serviceLife);
                        roadwork.AddList(roadwork);

                        // Обновление DataGridView
                        UpdateDataGridView();
                    }
                    else MessageBox.Show("Значения Ширина, Длина, Масса и Трафик не могут принимать значения меньше 0");

                }
                else
                {
                    MessageBox.Show("Проверьте правильность написания информации.");
                }
            }
            else MessageBox.Show("Заполните все поля");
        }
        private void removeButton1_Click(object sender, EventArgs e)//1
        {
            if (dataGridViewRoadWorks.SelectedRows.Count > 0)
            {
                var selectedRoadwork = (CoefOfSafety)dataGridViewRoadWorks.SelectedRows[0].DataBoundItem;
                Roadworks.RemoveRoadList(selectedRoadwork);
                UpdateDataGridView();
            }
            else MessageBox.Show("В базе данных не найдено информации");
        }
        private void removeButton2_Click(object sender, EventArgs e)//2
        {
                if (int.TryParse(textBoxIndex.Text, out int index))
                {
                    // Удаляем объект по индексу
                    Roadworks.RemoveRoadList(index);

                    // Обновляем DataGridView
                    UpdateDataGridView();
                }
                else
                {
                    MessageBox.Show("Пожалуйста, введите корректный индекс.");
                }
        }
        private void removeButton3_Click(object sender, EventArgs e)//3
        {
            if (!(textBoxWidth.Text == "" || textBoxLength.Text == "" || textBoxRoadMass.Text == "" ||
               textBoxLocation.Text == "" || comboBoxType.Text == "" || comboBoxP.Text == ""))
            {
                if (double.TryParse(textBoxWidth.Text, out double b1) && double.TryParse(textBoxLength.Text, out double b2) &&
                   double.TryParse(textBoxRoadMass.Text, out double b3) && double.TryParse(comboBoxP.Text, out double b4))
                {
                    double width = b1;
                    double length = b2;
                    double roadMass = b3;
                    double p = b4;
                    string location = textBoxLocation.Text;
                    string type = comboBoxType.Text;

                    Roadworks.RemoveRoadList(width, length, roadMass, location, type, p);
                    UpdateDataGridView();
                }
                else
                {
                    MessageBox.Show("Проверьте правильность написания информации.");
                }
            }
            else MessageBox.Show("Заполните все поля");
        }
        private void buttonQ_Click(object sender, EventArgs e)
        {
            if (dataGridViewRoadWorks.SelectedRows.Count > 0)
            {
                if (dataGridViewRoadWorks.SelectedRows.Count > 0)
                {
                    // Получаем выбранный объект
                    var selectedRoadwork = (Roadworks)dataGridViewRoadWorks.SelectedRows[0].DataBoundItem;

                    // Получаем первую выделенную строку
                    DataGridViewRow selectedRow = dataGridViewRoadWorks.SelectedRows[0];

                    // Получаем значение из нужного столбца
                    double cellValue = (double)selectedRow.Cells[0].Value;
                    // Вызываем метод GetInfo для получения информации
                    string info = selectedRoadwork.GetInfo(cellValue);

                    // Выводим информацию в MessageBox
                    MessageBox.Show(info, "Информация о дорожных работах");
                }
            }
            else MessageBox.Show("В базе данных не найдено информации");
        }

        private void dataGridViewRoadWorks_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Roadworks.SearchType(comboBoxSearchType.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxRoadMass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
