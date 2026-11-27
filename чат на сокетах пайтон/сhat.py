import asyncio
import websockets

async def chat():
    uri = "ws://localhost:8000/ws"
    async with websockets.connect(uri) as websockets:
        while True:
            message = input("введите сообщение")
            await websockets.send(message)
            responce = await websockets.recv()
            print(f"Сервер: {responce}")
asyncio.run(chat())