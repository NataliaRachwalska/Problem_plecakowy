using Problem_plecakowy;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Run_Click(object sender, EventArgs e)
        {
            listbox_instance.Items.Clear();
            listbox_result.Items.Clear();
            int numer;
            if (int.TryParse(textbox_num.Text, out numer) && int.TryParse(textbox_seed.Text, out numer) && int.TryParse(textbox_capacity.Text, out numer)) {
                if (int.Parse(textbox_num.Text) >= 0 && int.Parse(textbox_seed.Text) >= 0 && int.Parse(textbox_capacity.Text) >= 0) {
                    int liczba_przedmiotow = int.Parse(textbox_num.Text);
                    int nasionko = int.Parse(textbox_seed.Text);
                    int pojemnosc = int.Parse(textbox_capacity.Text);
                    List<Przedmiot> lista_przedmiotow = new List<Przedmiot>();
                    Problem pp = new Problem(liczba_przedmiotow, nasionko, lista_przedmiotow);
                    pp.lista_przedmiotow = pp.Losowanie(nasionko, liczba_przedmiotow);
                    foreach (Przedmiot p in pp.lista_przedmiotow)
                    {
                        listbox_instance.Items.Add(p);
                    }
                    pp.Sortowanie();
                    List<Przedmiot> plecak = new List<Przedmiot>();
                    int waga_sumaryczna = 0;
                    int wartosc_sumaryczna = 0;
                    Wynik wyn = new Wynik(plecak, waga_sumaryczna, wartosc_sumaryczna);
                    wyn = pp.Rozwiazanie(pojemnosc);
                    //listbox_result.Items.Add(wyn);
                    foreach (Przedmiot P in wyn.plecak)
                    {
                        listbox_result.Items.Add(P);
                    }
                    listbox_result.Items.Add($"Total Weight: {wyn.waga_sumaryczna}");
                    listbox_result.Items.Add($"Total Value: {wyn.wartosc_sumaryczna}");
                }
                else
                {
                    MessageBox.Show("Wartoœci powinny byæ wiêksze od zera", "B³¹d! Nieprawid³owa wartoœæ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
            else
            {
                MessageBox.Show("W polach powinny znajdowaæ siê tylko cyfry", "B³¹d! Nieprawid³owa wartoœæ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
