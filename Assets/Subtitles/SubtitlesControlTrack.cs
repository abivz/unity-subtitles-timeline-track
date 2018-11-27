using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.Playables;

[TrackColor(102f / 255f, 0f, 204f / 255f)]
[TrackBindingType(typeof(Subtitles))]
[TrackClipType(typeof(SubtitlesControlClip))]
public class SubtitlesControlTrack : TrackAsset
{

}