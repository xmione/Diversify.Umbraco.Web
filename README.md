# Diversify.Umbraco.Web

This small application implements a customized Grid Content template in Umbraco CMS with MVC Razor. Using the Grid Content Template, we can have flexibility in our CMS pages. For instance, we can allow editors to put any content or limit them to what type of content in any order in any column or row they specifically desire.


I’ve created two document types for the Home and Profile pages with two corresponding templates.

I’ve also added a master.css file that we can use to manipulate the style of the grid content and this did the trick snippet :

.umb-grid img{
     width: 100%;
}

That’s all folks.
