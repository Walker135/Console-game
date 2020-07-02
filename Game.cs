namespace ConsoleGame
{
    class Game : SuperGame
    {
        public new static void UpdatePosition(string keyPressed, out int xChange, out int yChange)
        {
            switch (keyPressed)
            {
                case "DownArrow":
                    xChange = 0;
                    yChange = 1;
                    break;

                case "UpArrow":
                    xChange = 0;
                    yChange = -1;
                    break;

                case "LeftArrow":
                    xChange = -1;
                    yChange = 0;
                    break;

                case "RightArrow":
                    xChange = 1;
                    yChange = 0;
                    break;

                default:
                    xChange = 0;
                    yChange = 0;
                    break;
            }
        }

        public new static char UpdateCursor(string keyPressed)
        {
            switch (keyPressed)
            {
                case "DownArrow":
                    return 'v';

                case "UpArrow":
                    return '^';

                case "LeftArrow":
                    return '<';

                case "RightArrow":
                    return '>';

                default:
                    return '<';

            }
        }

        public new static int KeepInBounds(int dimension, int boundy)
        {
            if (dimension >= 0 && dimension < boundy)
                return dimension;
            else if (dimension < 0)
                return 0;
            else
                return boundy - 1;
        }

        public new static bool DidScore(int chaX, int chaY, int fruX, int fruY)
        {
            if (chaX == fruX && chaY == fruY)
                return true;
            else
                return false;

        }
    }
}