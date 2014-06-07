function PageLoaded()
{
if (document.getElementById("frozen") != null && document.getElementById("scrollable") != null) {
  window.onscroll = UpdateFrozenDivLeftValue;
  window.onresize = UpdateFrozenDivLeftValue;
  document.getElementById("scrollable").style.paddingTop = document.getElementById("frozen").clientHeight+"px";
}

/*cells = document.getElementsByTagName("TD");
for (i = 0; i< cells.length; i++)
  {  
  if (cells[i].className == "catalog") 
    { 
     cells[i].setAttribute("onMouseOver", "catalogItemMouseOver(event)");
     cells[i].setAttribute("onMouseOut", "catalogItemMouseOut(event)");
    }
  }  */
}

/*function catalogItemMouseOver(eventArg)
  { 
  node = eventArg.srcElement;
  node.innerText = 'Открыть "' + node.innerText + '"';
  }
  
  function catalogItemMouseOut(eventArg)
  {  
   node = eventArg.srcElement;
   node.innerText = node.innerText.substring(9, node.innerText.length - 1);
  }*/

function ShowItem(itemId, itemGuid)
{
  window.external.ShowItem(itemId, itemGuid);
}

function GetById(name) {
	return document.getElementById(name);
}

function ShowObjectFieldsList(evt)
{
	fields = "";
	methods = "Не получилось получить значения для: \n";
	for(method in evt) 
	{
	memberName = method.toString();
	memberValue = "";
	try
		{
		memberValue = evt[memberName].toString();
		fields += memberName + " = " + memberValue + "\n";
		}
	catch (err)
		{
		memberValue = "";
		methods += memberName + "\n";
		}                            
	} 

	alert(fields);
	alert(methods);

}


function UpdateFrozenDivLeftValue() {
  
  var locationLeft = 0;
  if (navigator.appName=="Microsoft Internet Explorer") {
    locationLeft = 25 - document.documentElement.scrollLeft;
  } 
  else {
    locationLeft = 25 - document.body.scrollLeft;
  }
  
  var left =  locationLeft+ 'px';
  
  document.getElementById("frozen").style.left =left;
}