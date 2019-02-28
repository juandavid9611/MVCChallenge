using ClassLibrary1;
using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class Asteroid
    {
        public Links links { get; set; }
        public int element_count { get; set; }
        //public NearEarthObjects near_earth_objects { get; set; }
    }

    public class Links
    {
        public string next { get; set; }
        public string prev { get; set; }
        public string self { get; set; }
    }

    public class Links2
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

    public class EstimatedDiameter
    {
        public Kilometers kilometers { get; set; }
        public Meters meters { get; set; }
        public Miles miles { get; set; }
        public Feet feet { get; set; }
    }

    public class RelativeVelocity
    {
        public string kilometers_per_second { get; set; }
        public string kilometers_per_hour { get; set; }
        public string miles_per_hour { get; set; }
    }

    public class MissDistance
    {
        public string astronomical { get; set; }
        public string lunar { get; set; }
        public string kilometers { get; set; }
        public string miles { get; set; }
    }

    public class CloseApproachData
    {
        public string close_approach_date { get; set; }
        public object epoch_date_close_approach { get; set; }
        public RelativeVelocity relative_velocity { get; set; }
        public MissDistance miss_distance { get; set; }
        public string orbiting_body { get; set; }
    }

    public class __invalid_type__20150908
    {
        public Links2 links { get; set; }
        public string id { get; set; }
        public string neo_reference_id { get; set; }
        public string name { get; set; }
        public string nasa_jpl_url { get; set; }
        public double absolute_magnitude_h { get; set; }
        public EstimatedDiameter estimated_diameter { get; set; }
        public bool is_potentially_hazardous_asteroid { get; set; }
        public List<CloseApproachData> close_approach_data { get; set; }
        public bool is_sentry_object { get; set; }
    }

    public class Links3
    {
        public string self { get; set; }
    }

    public class Kilometers2
    {
        public double estimated_diameter_min { get; set; }
        public double estimated_diameter_max { get; set; }
    }

    public class Meters2
    {
        public double estimated_diameter_min { get; set; }
        public double estimated_diameter_max { get; set; }
    }

    public class Miles2
    {
        public double estimated_diameter_min { get; set; }
        public double estimated_diameter_max { get; set; }
    }

    public class Feet2
    {
        public double estimated_diameter_min { get; set; }
        public double estimated_diameter_max { get; set; }
    }

    public class EstimatedDiameter2
    {
        public Kilometers2 kilometers { get; set; }
        public Meters2 meters { get; set; }
        public Miles2 miles { get; set; }
        public Feet2 feet { get; set; }
    }

    public class RelativeVelocity2
    {
        public string kilometers_per_second { get; set; }
        public string kilometers_per_hour { get; set; }
        public string miles_per_hour { get; set; }
    }

    public class MissDistance2
    {
        public string astronomical { get; set; }
        public string lunar { get; set; }
        public string kilometers { get; set; }
        public string miles { get; set; }
    }

    public class CloseApproachData2
    {
        public string close_approach_date { get; set; }
        public object epoch_date_close_approach { get; set; }
        public RelativeVelocity2 relative_velocity { get; set; }
        public MissDistance2 miss_distance { get; set; }
        public string orbiting_body { get; set; }
    }

    public class __invalid_type__20150909
    {
        public Links3 links { get; set; }
        public string id { get; set; }
        public string neo_reference_id { get; set; }
        public string name { get; set; }
        public string nasa_jpl_url { get; set; }
        public double absolute_magnitude_h { get; set; }
        public EstimatedDiameter2 estimated_diameter { get; set; }
        public bool is_potentially_hazardous_asteroid { get; set; }
        public List<CloseApproachData2> close_approach_data { get; set; }
        public bool is_sentry_object { get; set; }
    }    
}
