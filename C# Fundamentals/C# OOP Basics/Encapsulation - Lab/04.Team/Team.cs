using System.Collections.Generic;

public class Team
{
    private string name;
    private List<Person> firstTeam;
    private List<Person> reserveTeam;

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }
    public Team(string name)
    {
        this.firstTeam = new List<Person>();
        this.reserveTeam = new List<Person>();
        this.Name = name;
    }
    public List<Person> FirstTeam
    {
        get { return this.firstTeam; }
    }
    public List<Person> ReserveTeam
    {
        get { return this.reserveTeam; }
    }
    public void AddPlayer(Person player)
    {
        if (player.Age < 40)
        {
            firstTeam.Add(player);
        }
        else
        {
            reserveTeam.Add(player);
        }
    }
}