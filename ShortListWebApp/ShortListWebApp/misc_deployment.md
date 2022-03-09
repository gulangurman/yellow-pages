Build project
    
    dotnet build

Run the build
 
    ASPNETCORE_URLS=http://127.0.0.1:64000 dotnet bin/Debug/net5.0/ShortListWebApp.dll

Nginx reverse proxy setup

    location /shortlist/ {
	    root [PROJECT_HOME]/shortlist/ShortListWebApp/ShortListWebApp;
	    client_max_body_size 2m;
        proxy_pass http://127.0.0.1:64000/; 
	    proxy_redirect off;
        proxy_set_header Host $host;
        proxy_set_header X-Real-IP $remote_addr;
        proxy_set_header X-Forwarded-For $proxy_add_x_forwarded_for;
        proxy_set_header X-Forwarded-Proto $scheme;
	    proxy_set_header Referer $http_referer;           
    }