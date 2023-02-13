using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

namespace OpticalFlow.Demo
{

    public class VideoStreamUpdater : TextureUpdater {

        [SerializeField] protected VideoPlayer videoPlayer;

        void Start () {
            videoPlayer.Play();
        }

        void Update ()
        {
            videoPlayer.Pause();
            
            if (videoPlayer.frame / videoPlayer.frameRate < Time.time) 
            {
                videoPlayer.StepForward();

                if ( null != videoPlayer.texture)
                    textureUpdateEvent.Invoke(videoPlayer.texture);
            }
        }
        /*
        void OnRenderImage(RenderTexture source, RenderTexture destination)
        {
            Graphics.Blit(webCamTexture, destination);
        }
        */
        protected void OnDestroy()
        {
        }

    }

}


