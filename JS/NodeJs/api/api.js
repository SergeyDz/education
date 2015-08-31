var request = require('request');

process.env['NODE_TLS_REJECT_UNAUTHORIZED'] = '0'; 

require('http').createServer(function (req, res) {

	if (req.method == 'POST') {
        console.log("POST");
        var credentials = '';

        req.on('data', function (data) {
            credentials = data;
            console.log("body: " + data);
        });

        req.on('end', function () {
            console.log("Body: " + credentials);
        });

		request.proxy = "http://127.0.0.1:8888";
		request.post(
			'https://mmss.bpmonline.com/ServiceModel/AuthService.svc/Login',
			{ "UserName" : 'Kozhina Masha', "UserPassword" : 'VZKO4xq4'},
			function (error, response, body) {
				if (!error && response.statusCode == 200) {
					console.log(body);
					res.writeHead(200, { 'Content-Type': 'application/json' });
					res.end(body);
				}
				else
				{
					res.writeHead(response.statusCode, { 'Content-Type': 'text/html' });
					console.log(error.Message);
					res.end(response);
				}
			});
    }
    else {
        console.log("GET");
        var html = 'get received';
        res.writeHead(200, { 'Content-Type': 'text/html' });
        res.end(html);
    }


}).listen(process.env.PORT);