using UnityEngine;

public interface IPlatform
{
    bool Flipped{get;}
    void SetFLippedState(bool flipped);
    void SetPlatformColor(Color color);

    
}
