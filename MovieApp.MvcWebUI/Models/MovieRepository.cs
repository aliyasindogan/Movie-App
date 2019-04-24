using System.Collections.Generic;
using System.Linq;

namespace MovieApp.MvcWebUI.Models
{
    public static class MovieRepository
    {
        private static List<Movie> movies = null;
        static MovieRepository()
        {
            movies = new List<Movie>()
           {
               new Movie(){Id=1,Name="Film 1",Image="1.jpg",Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam interdum erat eu augue rhoncus, vitae facilisis libero porta. Maecenas massa dolor, congue eu molestie sit amet, consectetur ac sapien. Donec feugiat convallis sollicitudin. Pellentesque vitae urna tellus. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Maecenas placerat rutrum est, a auctor ipsum semper nec. Vivamus dictum arcu in sollicitudin rutrum. Curabitur ac purus in lorem tincidunt volutpat. Vestibulum sodales quam ligula, nec tristique libero efficitur sit amet. In sit amet nisl scelerisque, commodo orci sed, viverra neque. Integer at justo a lacus bibendum molestie ac ut augue. In imperdiet nisi ac purus venenatis posuere." },
               new Movie(){Id=2,Name="Film 2",Image="2.jpg" ,Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam interdum erat eu augue rhoncus, vitae facilisis libero porta. Maecenas massa dolor, congue eu molestie sit amet, consectetur ac sapien. Donec feugiat convallis sollicitudin. Pellentesque vitae urna tellus. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Maecenas placerat rutrum est, a auctor ipsum semper nec. Vivamus dictum arcu in sollicitudin rutrum. Curabitur ac purus in lorem tincidunt volutpat. Vestibulum sodales quam ligula, nec tristique libero efficitur sit amet. In sit amet nisl scelerisque, commodo orci sed, viverra neque. Integer at justo a lacus bibendum molestie ac ut augue. In imperdiet nisi ac purus venenatis posuere." },
               new Movie(){Id=3,Name="Film 3",Image="3.jpg" ,Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam interdum erat eu augue rhoncus, vitae facilisis libero porta. Maecenas massa dolor, congue eu molestie sit amet, consectetur ac sapien. Donec feugiat convallis sollicitudin. Pellentesque vitae urna tellus. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Maecenas placerat rutrum est, a auctor ipsum semper nec. Vivamus dictum arcu in sollicitudin rutrum. Curabitur ac purus in lorem tincidunt volutpat. Vestibulum sodales quam ligula, nec tristique libero efficitur sit amet. In sit amet nisl scelerisque, commodo orci sed, viverra neque. Integer at justo a lacus bibendum molestie ac ut augue. In imperdiet nisi ac purus venenatis posuere." },
               new Movie(){Id=4,Name="Film 4",Image="4.jpg" ,Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam interdum erat eu augue rhoncus, vitae facilisis libero porta. Maecenas massa dolor, congue eu molestie sit amet, consectetur ac sapien. Donec feugiat convallis sollicitudin. Pellentesque vitae urna tellus. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Maecenas placerat rutrum est, a auctor ipsum semper nec. Vivamus dictum arcu in sollicitudin rutrum. Curabitur ac purus in lorem tincidunt volutpat. Vestibulum sodales quam ligula, nec tristique libero efficitur sit amet. In sit amet nisl scelerisque, commodo orci sed, viverra neque. Integer at justo a lacus bibendum molestie ac ut augue. In imperdiet nisi ac purus venenatis posuere." },
               new Movie(){Id=5,Name="Film 5",Image="5.jpg" ,Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam interdum erat eu augue rhoncus, vitae facilisis libero porta. Maecenas massa dolor, congue eu molestie sit amet, consectetur ac sapien. Donec feugiat convallis sollicitudin. Pellentesque vitae urna tellus. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Maecenas placerat rutrum est, a auctor ipsum semper nec. Vivamus dictum arcu in sollicitudin rutrum. Curabitur ac purus in lorem tincidunt volutpat. Vestibulum sodales quam ligula, nec tristique libero efficitur sit amet. In sit amet nisl scelerisque, commodo orci sed, viverra neque. Integer at justo a lacus bibendum molestie ac ut augue. In imperdiet nisi ac purus venenatis posuere." },
               new Movie(){Id=6,Name="Film 6",Image="6.jpg" ,Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam interdum erat eu augue rhoncus, vitae facilisis libero porta. Maecenas massa dolor, congue eu molestie sit amet, consectetur ac sapien. Donec feugiat convallis sollicitudin. Pellentesque vitae urna tellus. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Maecenas placerat rutrum est, a auctor ipsum semper nec. Vivamus dictum arcu in sollicitudin rutrum. Curabitur ac purus in lorem tincidunt volutpat. Vestibulum sodales quam ligula, nec tristique libero efficitur sit amet. In sit amet nisl scelerisque, commodo orci sed, viverra neque. Integer at justo a lacus bibendum molestie ac ut augue. In imperdiet nisi ac purus venenatis posuere." },
               new Movie(){Id=7,Name="Film 7",Image="7.jpg" ,Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam interdum erat eu augue rhoncus, vitae facilisis libero porta. Maecenas massa dolor, congue eu molestie sit amet, consectetur ac sapien. Donec feugiat convallis sollicitudin. Pellentesque vitae urna tellus. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Maecenas placerat rutrum est, a auctor ipsum semper nec. Vivamus dictum arcu in sollicitudin rutrum. Curabitur ac purus in lorem tincidunt volutpat. Vestibulum sodales quam ligula, nec tristique libero efficitur sit amet. In sit amet nisl scelerisque, commodo orci sed, viverra neque. Integer at justo a lacus bibendum molestie ac ut augue. In imperdiet nisi ac purus venenatis posuere." },
               new Movie(){Id=8,Name="Film 7",Image="8.jpg" ,Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam interdum erat eu augue rhoncus, vitae facilisis libero porta. Maecenas massa dolor, congue eu molestie sit amet, consectetur ac sapien. Donec feugiat convallis sollicitudin. Pellentesque vitae urna tellus. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Maecenas placerat rutrum est, a auctor ipsum semper nec. Vivamus dictum arcu in sollicitudin rutrum. Curabitur ac purus in lorem tincidunt volutpat. Vestibulum sodales quam ligula, nec tristique libero efficitur sit amet. In sit amet nisl scelerisque, commodo orci sed, viverra neque. Integer at justo a lacus bibendum molestie ac ut augue. In imperdiet nisi ac purus venenatis posuere." },
               new Movie(){Id=9,Name="Film 9",Image="9.jpg" ,Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam interdum erat eu augue rhoncus, vitae facilisis libero porta. Maecenas massa dolor, congue eu molestie sit amet, consectetur ac sapien. Donec feugiat convallis sollicitudin. Pellentesque vitae urna tellus. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Maecenas placerat rutrum est, a auctor ipsum semper nec. Vivamus dictum arcu in sollicitudin rutrum. Curabitur ac purus in lorem tincidunt volutpat. Vestibulum sodales quam ligula, nec tristique libero efficitur sit amet. In sit amet nisl scelerisque, commodo orci sed, viverra neque. Integer at justo a lacus bibendum molestie ac ut augue. In imperdiet nisi ac purus venenatis posuere." }
           };
        }

        public static List<Movie> Movies
        {
            get { return movies; }
        }

        public static void AddMovie(Movie movie)
        {
            movies.Add(movie);
        }

        public static Movie GetById(int id)
        {
            return movies.FirstOrDefault(x => x.Id == id);

        }
    }
}
