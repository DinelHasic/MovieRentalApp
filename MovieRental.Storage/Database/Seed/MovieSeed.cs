using MovieRental.Domain.Enteties;

namespace MovieRental.Storage.Seed
{
    internal class MovieSeed
    {
        public readonly static List<Movie> MOVIES = new()
        {
            new Movie(1, "E.T", "Alien in planet earth with a young boy", new DateTime(1982, 2, 1), "https://m.media-amazon.com/images/I/814-9+LgNTL._AC_SY445_.jpg"),
            new Movie(2, "Home Alone", "A boy home alone", new DateTime(1990, 1, 1), "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/zYPsleQJo1n1rBPlecJBRb3iwSO.jpg"),
            new Movie(3, "Jumanji", "When two kids find and play a magical board game, they release a man trapped in it for decades.", new DateTime(1995, 5, 2), "https://resizing.flixster.com/ubZExJkNr_7S3Nr1I8-wk8lg4DU=/206x305/v2/https://flxt.tmsimg.com/assets/p15446613_p_v8_ac.jpg"),
            new Movie(4, "Narnian", "Four kids travel through a wardrobe to the land of Narnia and learn of their destiny to free it with the guidance of a mystical lion.", new DateTime(2005, 9, 1),"https://m.media-amazon.com/images/M/MV5BMTc0NTUwMTU5OV5BMl5BanBnXkFtZTcwNjAwNzQzMw@@._V1_.jpg"),
            new Movie(5, "Jungle Book", "Mowgli is a boy brought up in the jungle by a pack of wolves. When Shere Khan, a tiger, threatens to kill him, a panther and a bear help him escape his clutches.", new DateTime(1987, 10, 18),"https://m.media-amazon.com/images/I/51qv0ish5JL._SY445_.jpg"),
            new Movie(6, "Lion King", "As a cub, Simba is forced to leave the Pride Lands after his father Mufasa is murdered by his wicked uncle, Scar. Years later, he returns as a young lion to reclaim his throne.", new DateTime(2019, 7, 12),"https://lumiere-a.akamaihd.net/v1/images/p_thelionking2019_19732_c1561d41.jpeg?region=0%2C0%2C540%2C810"),
            new Movie(7, "Scooby Doo", "Scooby-Doo! Mystery Mayhem is a video game based on the Hanna-Barbera/Warner Bros. cartoon Scooby-Doo. ", new DateTime(2005, 2, 15), "https://upload.wikimedia.org/wikipedia/en/a/ae/Scooby-Doo_poster.jpg"),
            new Movie(8, "The Lord of the Rings: The Return of the King", "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.", new DateTime(2003, 11, 2),"https://images.squarespace-cdn.com/content/v1/5935bdc315cf7d45e895fdfe/1557857896793-H0GROSO5OUE9NDE2IZ2I/LOTF---TTT-poster-credit-to-Metropolitan-Festival-Orchestra.jpg?format=1500w"),
            new Movie(9,"Green Book","A working-class Italian-American bouncer becomes the driver for an African-American classical pianist on a tour of venues through the 1960s American South.",new DateTime(2018, 7, 21),"https://movieposters2.com/images/1614370-b.jpg"),
            new Movie(10,"Pixels","When aliens misinterpret video feeds of classic arcade games as a declaration of war, they attack the Earth in the form of the video games.",new DateTime(2015, 7, 5),"https://images-na.ssl-images-amazon.com/images/S/pv-target-images/856aa43a655cd0c2b44f0e99bf8daed3b817c72b289ec0557469ca3f420af75a._RI_V_TTW_.png"),
        };
    }
}
