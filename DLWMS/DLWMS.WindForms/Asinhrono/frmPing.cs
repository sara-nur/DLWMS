using System.Net.NetworkInformation;

namespace DLWMS.WindForms.Asinhrono;
public partial class frmPing : Form
{
    public string Sadrzaj { get; set; }
    public frmPing()
    {
        InitializeComponent();
    }
    private void frmPing_Load(object sender, EventArgs e)
    {
        PostaviPodrazumijevanjeVrijednosti();
    }
    private void PostaviPodrazumijevanjeVrijednosti()
    {                                            
        txtUrl.Text = "www.google.ba";
        cmbBrojPonavljanja.SelectedIndex = 0;
        cmbPauza.SelectedIndex = 0;
    }
    private void PingSite(object obj)
    {
        try
        {
            var ping = new Ping();
            var pingConfig = obj as dtoPing;
            for (int i = 0; i < pingConfig.BrojPonavljanja; i++)
            {
                var odgovor = ping.Send(pingConfig.Url);
                Sadrzaj += PingReplyToString(odgovor);
                Thread.Sleep(pingConfig.Pauza);
                BeginInvoke(PrikaziSadrzaj);
            }
        }
        catch (Exception ex)
        {
            Sadrzaj = ex.Message;
        }
    }
    private string PingReplyToString(PingReply odgovor)
    {
        return $"{odgovor.Address}\t{odgovor.RoundtripTime}\t{odgovor.Status}{Environment.NewLine}";
    }
    private void btnPing_Click(object sender, EventArgs e)
    {
        var brojPonavljanja = int.Parse(cmbBrojPonavljanja.Text);
        var pauza = int.Parse(cmbPauza.Text);
        var url = txtUrl.Text;

        Thread google = new Thread(() => PingSite(new dtoPing()
        {
            BrojPonavljanja = brojPonavljanja,
            Pauza = pauza,
            Url = url,
        }));

        Thread yahoo = new Thread(() => PingSite(new dtoPing()
        {
            BrojPonavljanja = brojPonavljanja,
            Pauza = pauza,
            Url = url,
        }));
        yahoo.Start();

        PrikaziSadrzaj();
    }
    private void PrikaziSadrzaj()
    {
        txtIspis.Text = Sadrzaj;
        PomjeriNaKraj();
    }
    private void PomjeriNaKraj()
    {
        txtIspis.SelectionStart = txtIspis.Text.Length;
        txtIspis.ScrollToCaret();
    }
    public class dtoPing
    {
        public int BrojPonavljanja { get; set; }
        public int Pauza { get; set; }
        public string Url { get; set; }
    }

}
