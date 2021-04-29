<h1>.NET Core 3.1 MVC using Ocelot API Gateway (Configured for MAC, minor update needed for it to run on Windows)</h1>
<h2>Prerequisites</h2>
<ul><li>
.net Core 3.1 sdk </li><li>
<b>That's it! (It's platform independent so should work on any platform)</b>
</li></ul>
</li>
<h2> 
Thins to remeber prior to running the project</h2>
<ul><li>
All the 3 solutions need to run for the Ocelot Gateway to work!  
</li>
<li>Minor updates needed to be made in Ocelot.json file for it to work on IIS express, as IIS doesn't support MAC the current port numbers are not configured to work for IIS</li>
<li>
Look for the port nubmers being used in ocelot.json file and copy the proper port numbers from the respective APIs
</li>
<li>For example: for CustomerAPI, look into the launchsettings and copy the port number of IIS express and paste the same in ocelot.json, same procedure to be followed for ProductsAPI</li>
<li> If port numbers are not updated then Gateway will throw error but the individual APIs would still work</li>
</ul>

<h3>Thank you!<h3>
