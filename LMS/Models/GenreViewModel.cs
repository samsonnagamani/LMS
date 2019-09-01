using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LMS.Models
{
    public class GenreViewModel
    {
 

        public static List<SelectListItem> Genres { get; } = new List<SelectListItem>
        {
            new SelectListItem
            {
                Value = "",
                Text = "Genre"
            },
            new SelectListItem
            {
                Value = "Action",
                Text = "Action"
            },
            new SelectListItem
            {
                Value = "Adventure",
                Text = "Adventure"
            },
            new SelectListItem
            {
                Value = "Comedy",
                Text = "Comedy"
            },
            new SelectListItem
            {
                Value = "Children",
                Text = "Children"
            },
            new SelectListItem
            {
                Value = "Comic",
                Text = "Comic"
            },
            new SelectListItem
            {
                Value = "Drama",
                Text = "Drama"
            },
            new SelectListItem
            {
                Value = "Fairytale",
                Text = "Fairytale"
            },
            new SelectListItem
            {
                Value = "Fantasy",
                Text = "Fantasy"
            },
            new SelectListItem
            {
                Value = "Graphic",
                Text = "Graphic"
            },
            new SelectListItem
            {
                Value = "Horror",
                Text = "Horror"
            },
            new SelectListItem
            {
                Value = "Mystery",
                Text = "Mystery"
            },
            new SelectListItem
            {
                Value = "Poetry",
                Text = "Poetry"
            },
            new SelectListItem
            {
                Value = "Politics",
                Text = "Politics"
            },
            new SelectListItem
            {
                Value = "Romance",
                Text = "Romance"
            },
            new SelectListItem
            {
                Value = "SciFi",
                Text = "SciFi"
            },
            new SelectListItem
            {
                Value = "Short",
                Text = "Short"
            },
            new SelectListItem
            {
                Value = "Thriller",
                Text = "Thriller"
            },
        };
    }
}
