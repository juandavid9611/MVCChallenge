using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    class Class2
    {
    }

    public class Rootobject
    {
        public Links links { get; set; }
        public int element_count { get; set; }
        public Dictionary<string, Item[]> near_earth_objects { get; set; }
    }
    
    public class Links
    {
        public string next { get; set; }
        public string prev { get; set; }
        public string self { get; set; }
    }

    public class Item
    {
        public string id { get; set; }
        public string neo_reference_id { get; set; }
        public string name { get; set; }
        public string nasa_jpl_url { get; set; }
        public float absolute_magnitude_h { get; set; }
        public Estimated_Diameter estimated_diameter { get; set; }
        public bool is_potentially_hazardous_asteroid { get; set; }
        public Close_Approach_Data[] close_approach_data { get; set; }
        public bool is_sentry_object { get; set; }
        public double DistanceCalculate()
        {
            double ligthVelocity = 299792.0;
            double distance = Math.Round(Double.Parse(this.close_approach_data[0].miss_distance.kilometers) / ligthVelocity, 2);
            return distance;
        }
    }

    public class Links1
    {
        public string self { get; set; }
    }

    public class Kilometers
    {
        public double estimated_diameter_min { get; set; }
        public double estimated_diameter_max { get; set; }
    }

    public class Meters
    {
        public double estimated_diameter_min { get; set; }
        public double estimated_diameter_max { get; set; }
    }

    public class Miles
    {
        public double estimated_diameter_min { get; set; }
        public double estimated_diameter_max { get; set; }
    }

    public class Feet
    {
        public double estimated_diameter_min { get; set; }
        public double estimated_diameter_max { get; set; }
    }


    public class Estimated_Diameter
    {
        public Kilometers kilometers { get; set; }
        public Meters meters { get; set; }
        public Miles miles { get; set; }
        public Feet feet { get; set; }
    }
    public class Close_Approach_Data
    {
        public string close_approach_date { get; set; }
        public long epoch_date_close_approach { get; set; }
        public Relative_Velocity relative_velocity { get; set; }
        public Miss_Distance miss_distance { get; set; }
        public string orbiting_body { get; set; }
    }

    public class Relative_Velocity
    {
        public string kilometers_per_second { get; set; }
        public string kilometers_per_hour { get; set; }
        public string miles_per_hour { get; set; }
    }

    public class Miss_Distance
    {
        public string astronomical { get; set; }
        public string lunar { get; set; }
        public string kilometers { get; set; }
        public string miles { get; set; }
    }
}
