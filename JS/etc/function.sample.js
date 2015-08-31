var x='GLOBAL';

//f1internal('hm....');
function1('test before');

function function1(x)
{
	alert('function1: x=' + x);
	
	this.f1i = function(y)
	{
		alert('f1i: y=' + y);
		alert('f1i: x=' + x);
	}
}

var function2 = function(x)
{
	alert('function2: x=' + x);
}

var function3 = new Function("alert('function3: x=' + x);");

//run functions here
function1('a');
function2('b');
function3('c');
var f1 = new function1('1');
f1.f1i('2');
