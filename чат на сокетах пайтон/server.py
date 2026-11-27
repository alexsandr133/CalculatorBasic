from fastapi import FastAPI, WebSockets, WebSoketDisconnect
from typing import List

app = FastAPI()
#класс для установки соединения
class ConnectionManager:
    def __init__(self):
        self.active_connections: List[WebSockets] = []
        
        async def connnect(self, websocket: WebSockets):
            await websocket.accept()
            self.active_connections.append(websocket)
            
        def connect(self, websocket: WebSockets):
            self.active_connections.remove(websocket)
        async def broadcast(self, message, str):
            for connection in self.active_connections:
                await connection.send_text(message)
                
    manager = ConnectionManager()
    
    @app.websocket("/ws")
    async def websocket_endpoint(websocket: WebSockets):
        await manager.connect(websocket)
        try:
            while True:
                data = await websocket.receive_text()
                await manager.broadcast(f"user says: {data}")
        except WebSocketDisconnect:
            manager.disconnect(websocket)
            await manager.broadcast("User disconnected")
                 