﻿
using Android.App;
using Android.OS;
using Android.Widget;

namespace Movie_Search
{
    [Activity(Label = "MovieActivity")]
    public class MovieActivity : Activity
    {
        /*
         * Declaring variables
         */
        private TextView MovieTitle;
        private TextView MovieBio;
        private TextView MovieRating;
        private TextView MovieReleased;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.movie_activity);

            MainActivity.SearchButton.Text = "SEARCH";

            MovieTitle = (TextView)FindViewById(Resource.Id.movietitle);
            MovieBio = (TextView)FindViewById(Resource.Id.overview);
            MovieRating = (TextView)FindViewById(Resource.Id.rating);
            MovieReleased = (TextView)FindViewById(Resource.Id.releasedate);

            /*
            * Assigning values retrieved from the API response
            */
            MovieTitle.Text = "Title : " + MainActivity.MovieTitle;
            MovieBio.Text = "Description : " + MainActivity.MovieBio;
            MovieRating.Text = "Rating : " + MainActivity.MovieRating;
            MovieReleased.Text = "Released on " + MainActivity.MovieReleased;

            /*
            * Implementing back function
            */
            var buttonBack = FindViewById<Button>(Resource.Id.Button_Back);
            buttonBack.Click += (sender, e) =>
            {
                this.Finish();
            };
        }

    }
}
