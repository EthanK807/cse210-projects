class GameManager
{
    private Player _currentPlayer;
    private bool _isSimulating;
    private List<Player> players;
    public GameManager(int numberOfPlayers)
    {
        for (int i = 0; i < numberOfPlayers; i++)
        {
            Console.WriteLine($"What is the name of this the {i} player?");
            string playerName = Console.ReadLine();
            Player player = new Player(playerName);
        }
    }
    public void PlayCourse(Course course)
    {
        for (int i = 0; i < 18; i++)
        {
            PlayHole(course.GetHole(i));
        }
    }
    public void PlayHole(Hole hole)
    {
        _isSimulating = true;
        while (_isSimulating)
        {
            foreach (Player player in players)
            {
                
            }
        }
    }
}