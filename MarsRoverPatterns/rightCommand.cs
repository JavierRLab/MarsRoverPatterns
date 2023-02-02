namespace MarsRoverPatterns
{
    internal class rightCommand : ICommand
    {
        private readonly Compass _compass;

        public rightCommand(Compass compass)
        {
            this._compass = compass;
        }

        public void Execute()
        {
            _compass.RotateRight();
        }
    }
}