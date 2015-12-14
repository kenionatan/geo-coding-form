using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;
using System.Net;
using System.Web;
using System.Configuration;
using System.IO;
using System.Xml;

public class Address
{
    public string Latitude { get; set; }
    public string Longitude { get; set; }
    public string Line1 { get; set; }
    public string Line2 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zip { get; set; }
    public string Country { get; set; }

    private AccurateToTypes _latLngAccuracy = 0;
    public AccurateToTypes LatLngAccuracy
    {
        get { return _latLngAccuracy; }
    }

    public override string ToString()
    {
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        sb.AppendLine(Line1);
        if (!string.IsNullOrEmpty(Line2)) sb.AppendLine(Line2);
        sb.Append(City);
        sb.Append(", ");
        sb.Append(State);
        sb.Append(" ");
        sb.Append(Zip);
        sb.Append(" ");
        sb.Append(Country);
        return sb.ToString();
    }

    public Address()
    {
    }

    public void GeoCode()
    {
        //get the maps key in the web config file
        string mapskey = ConfigurationManager.AppSettings["GoogleMapsAPIKey"];
        //setup a streamreader for retrieving data from Google.
        //--------------StreamReader sr = null;

        //Check to see if our maps key exists
        if (string.IsNullOrEmpty(mapskey))
        {
            throw new Exception("No valid google maps api key to use for geocoding.  Please add an app key named \"GoogleMapsAPIKey\" to the web.config file.");
        }

        //Create the url string to send our request to googs.
        string url = string.Format("https://maps.googleapis.com/maps/api/geocode/xml?address={0} +{1} +{2} +{3} +{4} +{5}&output=xml&oe=utf8&sensor=false&key={6}", Line1, Line2, City + ", ", State, Zip, Country, mapskey);

        //Create a web request client.
        var webClient = new WebClient();

        try
        {
            //retrieve our result and put it in a streamreader
             Latitude = webClient.DownloadString(url);
            //sr = new StreamReader(webClient.OpenRead(url));
            // Latitude = sr.ToString();
        }
        catch (Exception ex)
        {
            throw new Exception("An error occured while retrieving GeoCoded results from Google, the error was: " + ex.Message);
        }

        //var reader = new XmlTextReader(sr);
        //reader.Read();


        /* var xdoc = XDocument.Load(sr);
        foreach (var x in xdoc.Root.Elements("location"))
        {
            Console.WriteLine(x.ToString());
            var coord1 = x.Element("lat");
            var coord2 = x.Element("lng");
            // Latitude = coord1.Value;
            //Longitude = coord2.Value;
            Console.WriteLine("Date = {0}", coord1 == null ? "<empty>" : coord1.Value);
            Console.WriteLine("Time = {0}", coord2 == null ? "<empty>" : coord2.Value);
        }*/



        //while (reader.Read())
        //{

        //    if (reader.NodeType == XmlNodeType.Element)
        //    {
        //        if (reader.Name == "lat")
        //        {
        //            reader.Skip();
        //            Latitude = reader.ReadString();
        //            //string[] coord1 = { (reader.ReadString()) };
        //            //Console.WriteLine("{0}", reader.ReadString());
        //        }
        //        else if (reader.Name == "lng")
        //        {
        //            Longitude = reader.ReadString();
        //        }
        //    }
        //}






    }

    public enum AccurateToTypes : int
    {
        Unknown = 0,
        Country = 1,
        Region = 2,
        SubRegion = 3,
        Town = 4,
        PostCode = 5,
        Street = 6,
        Intersection = 7,
        Address = 8,
        Premises = 9
    }
}
