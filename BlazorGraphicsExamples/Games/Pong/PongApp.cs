#region License

/*
MIT License

Copyright (c) 2022 bugbit

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

#endregion

namespace BlazorGraphicsExamples.Games.Pong;

public class PongApp : GRApp
{
    public override void Initialize()
    {
        base.Initialize();

        Name = "Pong Game";
        Width = 600;
        Height = 400;
        UrlRoot = "pingpong";
        Assets.AddSound("hitSound", "pong/hitSound.wav");
        Assets.AddSound("scoreSound", "pong/scoreSound.wav");
        Assets.AddSound("wallHitSound", "pong/wallHitSound.wav");
        /*
        function loadImage(src) {
        return new Promise((resolve, reject)=> {
        console.log(src);

        var img = new Image();
        img.onload = ()=> resolve(img);
        img.src = src;
        });
        }

        const img = await loadImage(url)
        }
        */
    }
}