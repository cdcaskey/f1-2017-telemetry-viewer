# F1-2017-Telemetry-Viewer

A small project to get live telemetry data from F1 2017 and display it

## How it works

- The game emits telemetry data to a UDP port.
- `TelemetryViewer.Server` listens to the UDP port and then pushes out the data via SignalR to any connected clients
- Clients can then connect to the server via SignalR and display the data as desired

A small demo is included showing live throttle and brake traces for the player's car
