using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bracketmaker_II
{
    public partial class Form1 : Form
    {
        private string forceWinner;
        public Form1()
        {
            InitializeComponent();
            this.Show();
            runBracket();
        }

        public void runBracket()
        {
            team[] bracket = new team[64];
            string[] lines = System.IO.File.ReadAllLines("2017teams.csv");
            TextBox[] allBoxes = { tbChamp, tbChamp1, tbChamp2, tbff1, tbff2, tbff3, tbff4, tb81, tb82, tb83, tb84, tb85, tb86, tb87, tb88, tb161, tb162, tb163, tb164, tb165, tb166, tb167, tb168, tb169, tb1610, tb1611, tb1612, tb1613, tb1614, tb1615, tb1616, tb321, tb322, tb323, tb324, tb325, tb326, tb327, tb328, tb329, tb3210, tb3211, tb3212, tb3213, tb3214, tb3215, tb3216, tb3217, tb3218, tb3219, tb3220, tb3221, tb3222, tb3223, tb3224, tb3225, tb3226, tb3227, tb3228, tb3229, tb3230, tb3231, tb3232, tb641, tb642, tb643, tb644, tb645, tb646, tb647, tb648, tb649, tb6410, tb6411, tb6412, tb6413, tb6414, tb6415, tb6416, tb6417, tb6418, tb6419, tb6420, tb6421, tb6422, tb6423, tb6424, tb6425, tb6426, tb6427, tb6428, tb6429, tb6430, tb6431, tb6432, tb6433, tb6434, tb6435, tb6436, tb6437, tb6438, tb6439, tb6440, tb6441, tb6442, tb6443, tb6444, tb6445, tb6446, tb6447, tb6448, tb6449, tb6450, tb6451, tb6452, tb6453, tb6454, tb6455, tb6456, tb6457, tb6458, tb6459, tb6460, tb6461, tb6462, tb6463, tb6464 };
            //reset all colors incase this is a re-run
            for(int i = 0; i < allBoxes.Length; i++)
            {
                allBoxes[i].BackColor = Color.WhiteSmoke;
                allBoxes[i].ForeColor = Color.Black;
            }
            //read each line and make into a team
            for (int i = 0; i < 64; i++)
            {
                String[] temp2 = lines[i].Split(',');
                bracket[i] = new team(temp2[0], Int32.Parse(temp2[1]), Convert.ToDouble(temp2[2]), Convert.ToDouble(temp2[3]), Convert.ToDouble(temp2[4]));
            }
            //populate combobox
            for (int i = 0; i < 64; i++)
            {
                comboBoxTeam.Items.Add(bracket[i].getName());
            }
            //test read in
            showBracket(bracket);
            ///////////////////////////////
            //textboxes
            tb641.Text = bracket[0].getName();
            tb642.Text = bracket[1].getName();
            tb643.Text = bracket[2].getName();
            tb644.Text = bracket[3].getName();
            tb645.Text = bracket[4].getName();
            tb646.Text = bracket[5].getName();
            tb647.Text = bracket[6].getName();
            tb648.Text = bracket[7].getName();
            tb649.Text = bracket[8].getName();
            tb6410.Text = bracket[9].getName();
            tb6411.Text = bracket[10].getName();
            tb6412.Text = bracket[11].getName();
            tb6413.Text = bracket[12].getName();
            tb6414.Text = bracket[13].getName();
            tb6415.Text = bracket[14].getName();
            tb6416.Text = bracket[15].getName();
            tb6417.Text = bracket[16].getName();
            tb6418.Text = bracket[17].getName();
            tb6419.Text = bracket[18].getName();
            tb6420.Text = bracket[19].getName();
            tb6421.Text = bracket[20].getName();
            tb6422.Text = bracket[21].getName();
            tb6423.Text = bracket[22].getName();
            tb6424.Text = bracket[23].getName();
            tb6425.Text = bracket[24].getName();
            tb6426.Text = bracket[25].getName();
            tb6427.Text = bracket[26].getName();
            tb6428.Text = bracket[27].getName();
            tb6429.Text = bracket[28].getName();
            tb6430.Text = bracket[29].getName();
            tb6431.Text = bracket[30].getName();
            tb6432.Text = bracket[31].getName();
            tb6433.Text = bracket[32].getName();
            tb6434.Text = bracket[33].getName();
            tb6435.Text = bracket[34].getName();
            tb6436.Text = bracket[35].getName();
            tb6437.Text = bracket[36].getName();
            tb6438.Text = bracket[37].getName();
            tb6439.Text = bracket[38].getName();
            tb6440.Text = bracket[39].getName();
            tb6441.Text = bracket[40].getName();
            tb6442.Text = bracket[41].getName();
            tb6443.Text = bracket[42].getName();
            tb6444.Text = bracket[43].getName();
            tb6445.Text = bracket[44].getName();
            tb6446.Text = bracket[45].getName();
            tb6447.Text = bracket[46].getName();
            tb6448.Text = bracket[47].getName();
            tb6449.Text = bracket[48].getName();
            tb6450.Text = bracket[49].getName();
            tb6451.Text = bracket[50].getName();
            tb6452.Text = bracket[51].getName();
            tb6453.Text = bracket[52].getName();
            tb6454.Text = bracket[53].getName();
            tb6455.Text = bracket[54].getName();
            tb6456.Text = bracket[55].getName();
            tb6457.Text = bracket[56].getName();
            tb6458.Text = bracket[57].getName();
            tb6459.Text = bracket[58].getName();
            tb6460.Text = bracket[59].getName();
            tb6461.Text = bracket[60].getName();
            tb6462.Text = bracket[61].getName();
            tb6463.Text = bracket[62].getName();
            tb6464.Text = bracket[63].getName();
            this.Refresh();
            team[] roundThree = new team[32];
            int iterator = 0;
            //make that bracket ROUND OF 32
            for (int i = 0; i < 64; i += 2)
            {
                roundThree[iterator] = determineWinner(bracket[i], bracket[i + 1], 64);
                iterator++;
            }
            //textboxes
            tb321.Text = roundThree[0].getName();
            tb322.Text = roundThree[1].getName();
            tb323.Text = roundThree[2].getName();
            tb324.Text = roundThree[3].getName();
            tb325.Text = roundThree[4].getName();
            tb326.Text = roundThree[5].getName();
            tb327.Text = roundThree[6].getName();
            tb328.Text = roundThree[7].getName();
            tb329.Text = roundThree[8].getName();
            tb3210.Text = roundThree[9].getName();
            tb3211.Text = roundThree[10].getName();
            tb3212.Text = roundThree[11].getName();
            tb3213.Text = roundThree[12].getName();
            tb3214.Text = roundThree[13].getName();
            tb3215.Text = roundThree[14].getName();
            tb3216.Text = roundThree[15].getName();
            tb3217.Text = roundThree[16].getName();
            tb3218.Text = roundThree[17].getName();
            tb3219.Text = roundThree[18].getName();
            tb3220.Text = roundThree[19].getName();
            tb3221.Text = roundThree[20].getName();
            tb3222.Text = roundThree[21].getName();
            tb3223.Text = roundThree[22].getName();
            tb3224.Text = roundThree[23].getName();
            tb3225.Text = roundThree[24].getName();
            tb3226.Text = roundThree[25].getName();
            tb3227.Text = roundThree[26].getName();
            tb3228.Text = roundThree[27].getName();
            tb3229.Text = roundThree[28].getName();
            tb3230.Text = roundThree[29].getName();
            tb3231.Text = roundThree[30].getName();
            tb3232.Text = roundThree[31].getName();
            this.Refresh();
            System.Console.WriteLine("");
            System.Console.WriteLine("ROUND OF 32");
            showBracket(roundThree);
            //make that bracket SWEET 16
            team[] SweetSixteen = new team[16];
            iterator = 0;
            for (int i = 0; i < 32; i += 2)
            {
                SweetSixteen[iterator] = determineWinner(roundThree[i], roundThree[i + 1], 32);
                iterator++;
            }
            //textboxes
            tb161.Text = SweetSixteen[0].getName();
            tb162.Text = SweetSixteen[1].getName();
            tb163.Text = SweetSixteen[2].getName();
            tb164.Text = SweetSixteen[3].getName();
            tb165.Text = SweetSixteen[4].getName();
            tb166.Text = SweetSixteen[5].getName();
            tb167.Text = SweetSixteen[6].getName();
            tb168.Text = SweetSixteen[7].getName();
            tb169.Text = SweetSixteen[8].getName();
            tb1610.Text = SweetSixteen[9].getName();
            tb1611.Text = SweetSixteen[10].getName();
            tb1612.Text = SweetSixteen[11].getName();
            tb1613.Text = SweetSixteen[12].getName();
            tb1614.Text = SweetSixteen[13].getName();
            tb1615.Text = SweetSixteen[14].getName();
            tb1616.Text = SweetSixteen[15].getName();
            this.Refresh();
            System.Console.WriteLine("");
            System.Console.WriteLine("SWEET 16");
            showBracket(SweetSixteen);
            //make that bracket ELITE 8
            team[] EliteEight = new team[8];
            iterator = 0;
            for (int i = 0; i < 16; i += 2)
            {
                EliteEight[iterator] = determineWinner(SweetSixteen[i], SweetSixteen[i + 1], 16);
                iterator++;
            }
            //textboxes
            tb81.Text = EliteEight[0].getName();
            tb82.Text = EliteEight[1].getName();
            tb83.Text = EliteEight[2].getName();
            tb84.Text = EliteEight[3].getName();
            tb85.Text = EliteEight[4].getName();
            tb86.Text = EliteEight[5].getName();
            tb87.Text = EliteEight[6].getName();
            tb88.Text = EliteEight[7].getName();
            this.Refresh();
            System.Console.WriteLine("");
            System.Console.WriteLine("ELITE 8");
            showBracket(EliteEight);
            //make that bracket FINAL 4
            team[] FinalFour = new team[4];
            iterator = 0;
            for (int i = 0; i < 8; i += 2)
            {
                FinalFour[iterator] = determineWinner(EliteEight[i], EliteEight[i + 1], 8);
                iterator++;
            }
            //text boxes
            tbff1.Text = FinalFour[0].getName();
            tbff2.Text = FinalFour[1].getName();
            tbff3.Text = FinalFour[2].getName();
            tbff4.Text = FinalFour[3].getName();
            this.Refresh();
            System.Console.WriteLine("");
            System.Console.WriteLine("FINAL 4");
            showBracket(FinalFour);
            //make that bracket CHAMPIONSHIP
            team[] Championship = new team[2];
            iterator = 0;
            for (int i = 0; i < 4; i += 2)
            {
                Championship[iterator] = determineWinner(FinalFour[i], FinalFour[i + 1], 4);
                iterator++;
            }
            //textboxes
            tbChamp1.Text = Championship[1].getName();
            tbChamp2.Text = Championship[0].getName();
            this.Refresh();
            System.Console.WriteLine("");
            System.Console.WriteLine("Championship");
            showBracket(Championship);

            team champ = determineWinner(Championship[0], Championship[1], 2);
            tbChamp.Text = champ.getName();
            System.Console.WriteLine("");


            ///////////////////////////////
            //coloring
            //make master textbox array
            //track champs and final four with colors
            tbChamp.BackColor = Color.Green;
            tbChamp.ForeColor = Color.White;
            team runnerup = Championship[0];
            if (champ == Championship[0])
            {
                runnerup = Championship[1];
            }
            team ff1 = null, ff2 = null;
            bool skip = false;
            for (int i = 0; i < FinalFour.Length; i++)
            {
                if (champ == FinalFour[i])
                {
                    System.Console.WriteLine("champ equals, skipping");
                    continue;
                }
                if (runnerup == FinalFour[i])
                {
                    System.Console.WriteLine("r.u. equals, skipping");
                    continue;
                }
                if (skip)
                {
                    System.Console.WriteLine("skip false, ff2 = ff@" + i);
                    ff2 = FinalFour[i];
                    continue;
                }
                System.Console.WriteLine("ff1=ff@" + i);
                ff1 = FinalFour[i];
                skip = true;

            }


            //make colors for 4 final four teams
            for (int i = 0; i < allBoxes.Length; i++)
            {
                if (allBoxes[i].Text.Equals(champ.getName()))
                {
                    allBoxes[i].BackColor = Color.Red;
                    allBoxes[i].ForeColor = Color.White;
                    continue;
                }
                if (allBoxes[i].Text.Equals(runnerup.getName()))
                {
                    allBoxes[i].BackColor = Color.Blue;
                    allBoxes[i].ForeColor = Color.White;
                    continue;
                }
                if (allBoxes[i].Text.Equals(ff1.getName()))
                {
                    allBoxes[i].BackColor = Color.Green;
                    allBoxes[i].ForeColor = Color.White;
                }
                if (allBoxes[i].Text.Equals(ff2.getName()))
                {
                    allBoxes[i].BackColor = Color.Yellow;
                    allBoxes[i].ForeColor = Color.Black;
                }
            }
        }
        public team determineWinner(team a, team b, int round)
        {
            //random sleep to attempt to randomize system clock
            Random clock = new Random();
            System.Threading.Thread.Sleep(clock.Next(1,5)*10);
            //if user has specified winner, they must win
            if (a.getName().Equals(forceWinner)) {
                return a;
            }
            if (b.getName().Equals(forceWinner))
            {
                return b;
            }
            //initial checks
            if (a.getSeed() == 1 && b.getSeed() == 16)
            {
                System.Console.WriteLine("Special Case: 16 never beats 1");
                System.Console.WriteLine("WINNER = **" + a.getName() + "**");
                return a;
            }
            if (a.getSeed() == 2 && b.getSeed() == 15)
            {
                System.Console.WriteLine("Special Case: 15 barely beats 2");
                System.Console.WriteLine("WINNER = **" + a.getName() + "**");
                return a;
            }
            //FINAL SCORE PREDICTION

            //Find each team's adjusted pace. Multiply these together, and divide by the league average.
            //For each team, multiply their Offense with their Opponent's Defense, then Divide by the League Average
            //Multiply the predicted PPP (from above line) by the predicted game pace, and divide by 100 to get the final score
            //http://kenpom.com/index.php

            double tempo = (a.getTempo() * b.getTempo()) / 67.6;
            double aScore = (a.getADJOff() * b.getADJDef()) / 100;//a offense * b defense / league avg
            double bScore = (b.getADJOff() * a.getADJDef()) / 100;//a offense * b defense / league avg
            double aPoints = (aScore * tempo) / 100;
            double bPoints = (bScore * tempo) / 100;
            System.Console.WriteLine("INITIAL==" + a.getName() + "'s points: " + aPoints + " - " + b.getName() + "'s points: " + bPoints);
            //get some randomness in this thing

            //favourite multiplier - give the favorite some credit
            //determine favorite
            if (a.getSeed() < b.getSeed())
            {
                aPoints += aPoints * .35;
            }
            else if (b.getSeed() < a.getSeed())
            {
                bPoints += bPoints * .35;
            }
            else if (a.getSeed() == b.getSeed())
            {//seeds equal
             //do nothing
            }
            //high seed multiplier - they've been playing against better teams all year

            if (a.getSeed() < 5)
            {
                aPoints += aPoints * .3;
            }
            if (b.getSeed() < 5)
            {
                bPoints += bPoints * .3;
            }
            //6,11,and 8 seeds have fortune getting to the final four, but NOT further
            if (round > 4)
            {
                if (a.getSeed() == 6 || a.getSeed() == 8 || a.getSeed() == 11)
                {
                    aPoints += aPoints * .1;
                }
                if (b.getSeed() == 6 || b.getSeed() == 8 || b.getSeed() == 11)
                {
                    bPoints += bPoints * .1;
                }
            }
            //at large berth bonus - these teams did not win conference but are good and are big schools
            if (round > 4)
            {
                if (a.getSeed() == 7 || a.getSeed() == 9 || a.getSeed() == 10)
                {
                    aPoints += aPoints * .08;
                }
                if (b.getSeed() == 7 || b.getSeed() == 9 || b.getSeed() == 10)
                {
                    bPoints += bPoints * .08;
                }
            }
            //top seed championship bonus - team seed > 8 has never made it to championship game
            if (round > 4)
            {
                if (a.getSeed() < 8)
                {
                    aPoints += aPoints * .23;
                }
                if (b.getSeed() < 8 )
                {
                    bPoints += bPoints * .23;
                }
            }
            //top seeds exceed in late rounds 
            if (round < 9)
            {
                if (a.getSeed() < 5)
                {
                    aPoints += aPoints * .3;
                }
                if (b.getSeed() < 5)
                {
                    bPoints += bPoints * .3;
                }
            }


            //add together
            double totalPoints = aPoints + bPoints;
            System.Console.WriteLine("AFTER==" + a.getName() + "'s points: " + aPoints + " - " + b.getName() + "'s points: " + bPoints + " Total Points = " + totalPoints);
            //pick winner randomly
            //double winner = (Math.random() * totalPoints);
            Random rnd = new Random();
            double winner = rnd.NextDouble()*totalPoints;
            System.Console.WriteLine("random # = " + winner);
            if (winner < aPoints)
            {
                System.Console.WriteLine("WINNER = **" + a.getName() + "**");
                return a;
            }
            System.Console.WriteLine("WINNER = **" + b.getName() + "**");
            return b;


        }
       public void showBracket(team[] bracket)
        {
            for (int i = 0; i < bracket.Length; i++)
            {
                System.Console.WriteLine(bracket[i].getName());
            }
        }
        private void RAButton_Click(object sender, EventArgs e)
        {
            runBracket();
        }

        private void RUButton_Click(object sender, EventArgs e)
        {
            forceWinner = comboBoxTeam.Text;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            //this should pause the thread once I figure out how
            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            System.Console.WriteLine("Clicked clear");
            forceWinner = "null";
        }
    }
}
