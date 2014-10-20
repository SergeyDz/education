window.alert = function(text)
{
	var console = document.getElementById('body');
	console.innerHTML = console.innerHTML + '<br/>' + '[' + (new Date()).toLocaleTimeString() + ']: ' + text
}