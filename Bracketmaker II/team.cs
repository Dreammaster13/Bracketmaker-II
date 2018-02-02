using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bracketmaker_II
{
    public class team
    {
 
        //shooting, turnover,rebound,and freethrow are all percentages (so if number is 50 than its 50%)
            private int wins;
            private int RPI;          //http://espn.go.com/mens-college-basketball/rpi/_/sort/RPI
                                      //private double shooting;  //http://www.ncaa.com/stats/basketball-men/d1/current/team/148
                                      //private double turnover;  //http://www.ncaa.com/stats/basketball-men/d1/current/team/519
                                      //private double rebound;   //http://www.ncaa.com/stats/basketball-men/d1/current/team/151
                                      //private double freethrow; //http://www.ncaa.com/stats/basketball-men/d1/current/team/150
            private double ADJOff, ADJDef, tempo; //points per poss, opp points per poss, average possessions per game
            private String name;
            private int seed;
            public team(String n, int s, int w, int ss)
            {
                name = n;
                seed = s;
                wins = w;
                RPI = ss;
            }
            public team(String n, int s, double o, double d, double t)
            {
                name = n;
                seed = s;
                ADJOff = o;
                ADJDef = d;
                tempo = t;
            }
            //pre: int x
            //post sets wins to x
            public void setwins(int x)
            {
                wins = x;
            }

            //pre: int wins exists
            //post returns wins
            public int getwins()
            {
                return wins;
            }
            //pre: int x
            //post sets RPI to x
            public void setRPI(int x)
            {
                RPI = x;
            }

            //pre: int RPI exists
            //post returns RPI
            public int getRPI()
            {
                return RPI;
            }
            //pre: String x
            //post sets name to x
            public void setName(String x)
            {
                name = x;
            }

            //pre: String name exists
            //post returns name
            public String getName()
            {
                return name;
            }
            //pre: int x
            //post sets seed to x
            public void setSeed(int x)
            {
                seed = x;
            }

            //pre: int seed exists
            //post returns seed
            public int getSeed()
            {
                return seed;
            }
            //pre: int x
            //post sets ADJOff to x
            public void setADJOff(double x)
            {
                ADJOff = x;
            }

            //pre: int ADJOff exists
            //post returns ADJOff
            public double getADJOff()
            {
                return ADJOff;
            }
            //pre: int x
            //post sets ADJDef to x
            public void setADJDef(double x)
            {
                ADJDef = x;
            }

            //pre: int ADJDef exists
            //post returns ADJDef
            public double getADJDef()
            {
                return ADJDef;
            }
            //pre: int x
            //post sets tempo to x
            public void setTempo(double x)
            {
                tempo = x;
            }

            //pre: int tempo exists
            //post returns tempo
            public double getTempo()
            {
                return tempo;
            }
            public String toString()
            {
                return name + ":   Seed: " + seed + " Offense: " + ADJOff + " Defense: " + ADJDef + " Possessions: " + tempo + " RPI: " + RPI + "";
            }
        }

    }

