<h1 align="center">
  Can Avatars Shape Sustainable Consumer Food Choices? Exploring Social Norms in Virtual Worlds
</h1>

<div align="center">
    <img src="https://github.com/MCBLaboratory/Social-norms-and-the-Metverse/blob/main/Picture1.jpg">
</div>


<h2>Overview</h2>
<p>
  This project provides an immersive, canteen environment to explore how virtual avatars, interact, guide, and even influence the purchasing behaviour of others in real-time.

</p>

<h2>Requirements</h2>
<ul>
  <li><b>Windows PC:</b> Tested on Windows 11 25H2</li>
  <li><b>Virtual Reality:</b> Tested with a Varjo XR3 & Meta Quest 3 VR headset</li>
  <li><b>Unity 2022.3.22f1 or higher </b></li>
  <li><b>Unity Hub</b></li>
  <li><b>(Inside-out tracking) SteamVR & min. 2x HTC/Valve Base Stations V1.0 or V2.0</b></li>
  </li>
</ul>

<h2>Getting Started</h2>

<p><strong>Note:</strong> On first launch, the main scene might appear hidden. To open it, go to <b>Assets → Scene → Scene.unity</b>.</p>

<ol>
  <li>Clone the repository or download the .zip from the green "Code" button:<br>
    <code>git clone https://github.com/MCBLaboratory/Social-norms-and-the-Metverse</code>
  </li>
</ol>

<h2>Unity Versions & Dependencies</h2>
<ul>
  <li><b>Operating System:</b> Windows 10 or 11</li>
  <li><b>Unity Versions:</b>
    <ul>
      <li><b>Windows PC:</b> Tested with Unity <code>2022.3.22f1</code></li>
    </ul>
  </li>
  <li><b>Required Unity Packages:</b>
    <ol>
					    <li>
    <b>OpenXR:</b>
    <a href="https://github.com/needle-mirror/com.unity.xr.openxr" target="_blank">OpenXR</a>
  </li>
	    <li>
    <b>VarjoUnityXRPlugin:</b>
    <a href="https://github.com/varjocom/VarjoUnityXRPlugin" target="_blank">Varjo XR Unity Companion</a>
  </li>
<i></i>
      <li>Post Processing</li>
      <li>TextMeshPro</li>
	  <li>AI Navigation (v1.1.7 or higher)</li>
    </ol>
  </li>
</ul>

<h3>Included Scripts</h3>
<table border="1" cellpadding="8" cellspacing="0">
  <thead>
    <tr>
      <th>Script</th>
      <th>Description</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td><b>Scripts/TODO</b></td>
      <td>TODO</td>
    </tr>
    <tr>
      <td><b>TODO</b></td>
      <td>TODO</td>
    </tr>
    
  </tbody>
</table>

<h2>Scene</h2>

<p>
This scene simulates an interactive digital twin of a university canteen, developed to explore the hypothesised effects of the Metaverse-based social norms. The designed VR-study employed a 2x2 between-subjects experimental design, manipulating two independent variables: social norm type (descriptive norm (DN) vs. injunctive norm (IN)) and social norm format (immersive (EXP) vs. textual (TEXT)). This resulted in four experimental conditions to which participants were randomly assigned using a randomiser embedded in the Qualtrics survey flow. At the start of th experiment, participants can choose between four groups.
</p>
<p><b>>Group 1:</b Participants observed a queue of virtual avatars ahead of them, each elaborating on their decision to choose the sustainable meal.</p>
<p><b>Group 2:</b> The norm message for the descriptive norm–textual condition (DN-TEXT) stated that most people choose the sustainable option.</p>
<p><b>Group 3:</b> Participants are placed in a protest-like setting populated by virtual avatars advocating for more environmentally responsible food choices.</p>
<p><b>Group 4:</b> The norm message for the descriptive norm–textual condition (DN-TEXT) indicated that choosing the sustainable option is the "right" thing to do.</p>

<h2>Miscellaneous</h2>
<ol>
  <li>The project is technically compatible with all major VR headsets (HTC, Meta/Oculus, Valve, WMR headsets), Windows PC's and Android or iOS smartphones.</li>
  <li>The game logic is written in C#.</li>
	<li>
    The project is configured for a <strong>Varjo</strong> headset and
    <strong>Valve Index Controllers</strong>.
  </li>
  <li>
    To change the VR headset settings (e.g., add Meta Quest 3), disable
    <strong>Varjo</strong> and enable <strong>OpenXR</strong> in
    <em>Project Settings → XR Plug-in Management</em>.
  </li>
  <li>
    To update the controller configuration, navigate to
    <em>Project Settings → XR Plug-in Management → OpenXR</em> and replace the
    <strong>Valve Index Controller Profile</strong> with another (e.g., Meta Quest controllers)
    using the <code>+</code> / <code>−</code> icons.
  </li>
  <li>
    The <strong>OpenXR Simulator</strong> can be enabled to use keyboard and mouse controls:
    <ul>
      <li>In the Hierarchy, enable <em>Setup → XR Device Simulator</em>.</li>
      <li>
        In the Game view, press the <code>+</code> on the simulator’s control window to view
        the input mappings.
      </li>
      <li>
        Navigation may feel unintuitive at first, but the on-screen guide helps clarify the
        control scheme.
      </li>
    </ul>
  </li>
</ol>

<h2>Development Team</h2>
<p>Development by Juriaan Wolfers (WUR), project managed by Caspar Krampe (WUR).</p>

<h2>License</h2>
<p>
  Copyright © 2026 Wageningen University &amp; Research.
</p>

<p>
  This project is licensed under the <strong>MIT License</strong>. You are free to use, modify, and distribute this software and documentation, provided that the original copyright notice and this permission notice are included in all copies or substantial portions of the software.
</p>

<p align="center">
  <a href="./LICENSE" target="_blank">View full license text</a>
</p>

<hr>

<h2>Citation</h2>
<p>
If you use this code in your research, please cite:<br><br>
 Krampe, C., Mehlhose, C., Wolfers, J., Van Loo, E. J., Hurst, W. (2026). Can Avatars Shape Sustainable Consumer Food Choices? Exploring Social Norms in Virtual Worlds?
</p>
