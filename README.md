<h1>Water Shader Engine Comparison</h1>
<h3>Unity</h3>
<img width="903" alt="UnityWater" src="/References/UnityWater.png">
<h3>Unreal</h3>
<img width="903" alt="UnityWater" src="/References/UnrealWater.png">

<h2>Water shader implementation</h2>
<p>To create realistic looking waves, I researched common methods used in video games and chose the Gerstner Wave formula, because it is realistic and has enough complexity to make a measurable impact on the performance. I followed a YouTube tutorial to implement it into Unity using Shader Graph. The variables didn’t seem to make an impact on performance, so I tweaked them to my liking. Next, I created the Unreal project and changed the settings to turn off post processing, to match it as close to Unity as possible. My next goal was to create the shader in Unreal which was the most time-consuming part of this assignment, because there were some differences in the material settings, missing functions, different coordinate spaces and difference in the normals.</p>

<h2>Links</h2>
<a href="https://www.youtube.com/watch?v=V4yZigMSLiU">Inspiration</a>
<br>
<a href="https://www.youtube.com/watch?v=Awd1hRpLSoI">Unity Tutorial</a>
<br>
<a href="https://docs.google.com/spreadsheets/d/e/2PACX-1vT80uWBKb73ku9S5hPhv6_zbwnhXyaa934AvZXso1GGOdYo_qHmZuMw1ggZSFw_zXzQPYyYwGBTyM9D/pubhtml">Charts</a>

<h2>Testing</h2>
<img width="900" alt="UnityWater" src="/References/UnityChart3.png">
<img width="900" alt="UnityWater" src="/References/UnrealChart3.png">
<p>I tested the charts using from 1 to 20 planes each of which are ~6 million tris with and without the shader applied. Unity showed an exponential decay in performance, displaying a 20% drop when doubling the triagnles. Uneral showed a stable linear downward curve, dropping only 4% in the same scenario. Both engines' curve patterns are the same with and without the shader, but the real impact is in the FPS difference between testing with the default engine material and with the water shader. On average there is a 17.9 frame drop in performance in Unity and only 4.34 in Unreal</p>

<h2>Conclusion</h2>
<p>It appears that Unreal is performing way better at rendering water, which could be the result of a lot of factors such as translucent material optimisation.</p>
