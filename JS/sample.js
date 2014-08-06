window.alert = function(text)
{
	var console = document.getElementById('body');
	console.innerHTML = console.innerHTML + '<br/>' + '[' + (new Date()).toLocaleTimeString() + ']: ' + text
}

var element = function Element()
{
	var that = {
		render :  function()
				{
					alert('<input type="text" value="' + this.Value + '"/>')
				}
	}
	
	that.IsHidden = false;
	that.IsRequired = false;
	that.Width = 100;
	that.Help = 'Help text for Element'
	that.Value = '';
	
	return that;
}

var textBox = function TextBox()
{
	var that = element();
	that.Name = 'TextBox';
	that.Lenght = 255;
	that.Value = 'Empty';
	
	return that;
}

var textBox1 = textBox();
var textBox2 = textBox();

alert(textBox1.Help)

textBox1.Help = 'Help for textBox1';
alert(textBox1.Help)

alert(textBox1.Help)
alert(textBox2.Help)

textBox1.render('Hello world')