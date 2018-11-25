using UnityEngine;
using UnityEngine.Playables;

[System.Serializable]
public class SubtitlesControlBehaviour : PlayableBehaviour
{
    public int SubtitlesIndex;

    bool _firstFrameHappened;
    
    string _defaultText;

    Subtitles _subtitles;

    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
        _subtitles = playerData as Subtitles;
        if (_subtitles == null)
            return;

        if (!_firstFrameHappened)
        {
            _defaultText = _subtitles.Text.text;
            _firstFrameHappened = true;
        }

        _subtitles.Text.text = _subtitles.SubtitlesSource.Subtitles[SubtitlesIndex];
    }

    public override void OnBehaviourPause(Playable playable, FrameData info)
    {
        _firstFrameHappened = false;
        
        if (_subtitles == null)
            return;
        
        _subtitles.Text.text = _defaultText;

        base.OnBehaviourPause(playable, info);
    }
}