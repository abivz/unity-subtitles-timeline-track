using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[System.Serializable]
public class SubtitlesControlClip : PlayableAsset, ITimelineClipAsset
{
    public SubtitlesControlBehaviour template = new SubtitlesControlBehaviour();

    public ClipCaps clipCaps
    {
        get
        {
            return ClipCaps.None;
        }
    }

    public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
    {
        return ScriptPlayable<SubtitlesControlBehaviour>.Create(graph, template);
    }
}