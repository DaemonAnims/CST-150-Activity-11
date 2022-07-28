namespace Activity_11
{
    public partial class DieRollerForm : Form
    {
        public DieRollerForm()
        {
            InitializeComponent();
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            //Clear previous rolls, if any
            rollsBox.Items.Clear();
            //instantiate dice
            Dice die1 = new Dice((int)die1_Size.Value);
            Dice die2 = new Dice((int)die2_Size.Value);

            int result1 = 0;
            int result2 = 0;
            int rollCounter = 0;

            //Do-While Loop (post-loop check for snake-eyes)
            do
            {
                //Roll Dice
                result1 = die1.RollDie();
                result2 = die2.RollDie();
                //Increase Roll Counter
                rollCounter++;
                //Add to display list
                rollsBox.Items.Add(result1 + ", " + result2);


            } while (result1 != 1 || result2 != 1);

            amountRollsLabel.Text = "Rolls taken until Snake Eyes: " + rollCounter;

        }
    }
}