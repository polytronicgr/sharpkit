<h1>Example: using Html DOM API in C#</h1>
The following example illustrates how to use the C# Model classes to manipulate the Html DOM.

<a href='http://sharpkit.googlecode.com/svn/trunk/samples/SharpKitSamples.HtmlAPI/index.htm'>Run this example</a>

```
using SharpKit.HtmlModel;
using SharpKit.JavaScriptModel;

namespace SharpKitSamples.HtmlAPI
{
	[JsType(JsMode.Global, "index.js")]
	class index : HtmlContext
	{
		public static bool tbNewTask_onkeypress(HtmlInput sender, HtmlDomEventArgs e)
		{
			//If enter is hit, blur the input
			if (e.keyCode == 13)
			{
				sender.blur();
				return false;
			}
			return true;
		}

		public static bool tbNewTask_onblur(HtmlInput sender, HtmlDomEventArgs e)
		{
			//when input is blured, insert a new item if it is not empty
			if (sender.value == null || sender.value == "")
				return false;
			var ul = document.getElementById("ulTaskList").As<HtmlUnorderedList>();
			var li = document.createElement<HtmlListItem>("li");
			li.appendChild(document.createTextNode(sender.value));
			var liNewTask = document.getElementById("liNewTask").As<HtmlListItem>();
			liNewTask.insertAdjacentElement("beforeBegin", li);

			//reset the input to blank
			sender.value = "";
			sender.focus();
			return true;
		}		
	}
}

```

The JavaScript code that was generated by SharpKit:

```
//@AutoGenerated
function tbNewTask_onkeypress(sender, e)
{
	if (e.keyCode == 13)
	{
		sender.blur();
		return false;
	}
	return true;
}
function tbNewTask_onblur(sender, e)
{
	if (sender.value == null || sender.value == "")
		return false;
	var ul = document.getElementById("ulTaskList");
	var li = document.createElement("li");
	li.appendChild(document.createTextNode(sender.value));
	var liNewTask = document.getElementById("liNewTask");
	liNewTask.insertAdjacentElement("beforeBegin", li);
	sender.value = "";
	sender.focus();
	return true;
}
```

The containing HTML page:
```
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
	<title>Html API example</title>
	<script src="index.js" type="text/javascript"></script>
</head>
<body>
	<h2>
		Html API example
	</h2>
	<p>
		Dynamically create Html elements and append them to the DOM.
	</p>
	<div style="border: solid 1px #cccccc; padding: 10px;">
		<b>Add a task and hit ENTER </b>
		<ul id="ulTaskList">
			<li>Buy bread</li>
			<li>Do Yoga</li>
			<li id="liNewTask">
				<input 
				type="text" 
				onblur="tbNewTask_onblur(this, event);" 
				onkeypress="return tbNewTask_onkeypress(this, event);"
					id="tbNewTask" />
			</li>
		</ul>
	</div>
</body>
</html>
```