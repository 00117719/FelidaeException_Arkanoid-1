namespace FelidaeException
{
    public class Belka
    {
        public void move(OknoGry okno, Paddle belka)
        {
            if (visible)
            {
                x += speedX;
                y += speedY;

                if (x < 0)
                {
                    x = 0;
                    speedX *= -1;
                }
                else if (x + width > okno.Width)
                {
                    x = okno.Width - width;
                    speedX *= -1;
                }

                if (((x > belka.getX() && x < belka.getX() + belka.getWidth()) || (x + width > belka.getX() && x + width < belka.getX() + belka.getWidth())) &&
                    (y + height > belka.getY() && y + height < belka.getY() + belka.getHeight()))//warunek zderzenia z belka
                {
                    applyBonus(bonus, belka, okno.pilka, okno.lista, okno);
                    dezaktywuj();
                }
                else if (y + height > okno.Height)
                {
                    dezaktywuj();
                }
            }
        }
    }
}