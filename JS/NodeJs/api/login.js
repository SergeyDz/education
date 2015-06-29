var request = require('request');

process.env['NODE_TLS_REJECT_UNAUTHORIZED'] = '0';

require('http').createServer(function (req, res) {

    if (req.method == 'POST') {
        console.log("POST");
        var credentials = '';

        req.on('data', function (data) {
            credentials = JSON.parse(data);
            console.log("body: " + data);
            
            request(
            {
                method: "POST",
                uri: "https://mmss.bpmonline.com/ServiceModel/AuthService.svc/Login",
                proxy: "http://127.0.0.1:8888", // Note the fully-qualified path to Fiddler proxy. No "https" is required, even for https connections to outside.
                json: credentials
            },
            function (error, response, body) {
                if (!error && response.statusCode == 200) {
					console.log(body);
					res.writeHead(200, { 'Content-Type': 'application/json' });
					res.end(JSON.stringify(body));
				}
				else
				{
					res.writeHead(response.statusCode, { 'Content-Type': 'text/html' });
					console.log(error.Message);
					res.end(response);
				}
            });
        });
    }
    else {
        console.log("GET");
        var html = 'get received';
        res.writeHead(200, { 'Content-Type': 'text/html' });
        res.end(html);
    }


}).listen(process.env.PORT);