Build project
    
    dotnet build

Run the build
 
    ASPNETCORE_URLS=http://127.0.0.1:64000 dotnet bin/Debug/net6.0/ShortListMVC.dll

Nginx reverse proxy setup

    location /shortlist/ {
	    root [PROJECT_HOME]/shortlist/ShortListWebApp/ShortListMVC;
	    client_max_body_size 2m;
        proxy_pass http://127.0.0.1:64000/; 
	    proxy_redirect off;
        proxy_set_header Host $host;
        proxy_set_header X-Real-IP $remote_addr;
        proxy_set_header X-Forwarded-For $proxy_add_x_forwarded_for;
        proxy_set_header X-Forwarded-Proto $scheme;
	    proxy_set_header Referer $http_referer;           
    }

Systemd setup to start automatically after boot

Add this to /etc/systemd/system
---
[Unit]
Description=ShortList service

[Service]
WorkingDirectory=/home/janeway/source/shortlist/ShortListWebApp/ShortListMVC
ExecStart=/usr/bin/dotnet bin/Debug/net6.0/ShortListMVC.dll
SyslogIdentifier=ShortListService
User=janeway
KillSignal=SIGINT
Environment=ASPNETCORE_ENVIRONMENT=Production
Environment=ASPNETCORE_URLS="http://localhost:64000"
Environment=DOTNET_PRINT_TELEMETRY_MESSAGE=true
Environment=ASPNETCORE_BASEPATH="/shortlist"

[Install]
WantedBy=multi-user.target
---

sudo systemctl daemon-reload
sudo systemctl start pha.shortlist.service
sudo systemctl restart pha.shortlist.service
sudo systemctl status pha.shortlist.service


