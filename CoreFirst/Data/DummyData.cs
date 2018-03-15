using CoreFirst.Data;
using CoreFirst.Models.NHL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoreFirstPrimer.Data
{
    public class DummyData
    {
        public static List<Team> getTeams()
        {
            List<Team> teams = new List<Team>()
            {

                new Team() {
          TeamId = 20,TeamName ="Canucks", City = "Vancouver",Province = "BC",},

                new Team() {
                      TeamId = 30, TeamName ="Oiler",City = "Edmonton",Province = "Alberta",},

                new Team() {
                            TeamId= 40, TeamName ="Flames",City = "Calgary",Province = "Alberta",}
                            };
            return teams;

        }

        public static List<Player> getPlayers()
        {
            List<Player> Players = new List<Player>() {
                new Player {
                    FirstName = "sven",LastName = "BAERTSCHI",TeamId = 20,Position = "Forward",PlayerId=1,},

                new Player {
                    FirstName = "Henrik",LastName = "Sedin",TeamId = 20,Position = "Left Wing"},

                new Player {
                    FirstName = "John",LastName = "Rooster",TeamId = 30,Position = "Right Wing"},

                new Player {
                    FirstName = "Bob",LastName = "Plumber",TeamId= 40,Position = "Defence"},
                            };
            return Players;
        }

        internal static object getPlayers(NhlContext context)
        {
            throw new NotImplementedException();
        }

        public static List<Country> getCountries()
        {
            List<Country> Football = new List<Country>()
            {
                new Country {
                    Id = 12345,Name = "argentina"
                },

                new Country {
                    Id = 1345,Name = "spain"
                }


            };
            return Football;
        }
    }
}
