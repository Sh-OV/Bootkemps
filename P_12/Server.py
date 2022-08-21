import redis
import random

with redis.Redis() as redis_server:  # конструкция, которая автоматически закроектся как только отработает
    redis_server.lpush("queue", random.randint(0, 10))