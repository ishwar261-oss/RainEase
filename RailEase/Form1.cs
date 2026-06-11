namespace RailEase
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pnlSearchCard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblSearchTitle_MouseHover(object sender, EventArgs e)
        {
            lblSearchTitle.ForeColor = Color.FromArgb(255, 200, 61);
            
           
        }

        private void lblSearchTitle_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void lblSearchTitle_Move(object sender, EventArgs e)
        {
        }

        private void lblSearchTitle_MouseLeave(object sender, EventArgs e)
        {
            lblSearchTitle.ForeColor = Color.White;      
        }

        private void lblSearchTitle_Click(object sender, EventArgs e)
        {
            pnl1Und.Visible = true;
            pnl2Und.Visible = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            pnl1Und.Visible = false;
            pnl2Und.Visible = true;
        }

        private void label8_MouseHover(object sender, EventArgs e)
        {
            label8.ForeColor = Color.FromArgb(255, 200, 61);
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.ForeColor = Color.White;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
