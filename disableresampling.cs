using Sony.Vegas;

public class EntryPoint {

    public void FromVegas(Vegas vegas) 
    {
        foreach (Track track in vegas.Project.Tracks) 
        {
            if (track.IsVideo())
            {
                foreach (TrackEvent trackEvent in track.Events)
                {
                    VideoEvent videoEvent = (VideoEvent)trackEvent;
                    videoEvent.ResampleMode = VideoResampleMode.Disable;
                }
            }
        }
    }
}