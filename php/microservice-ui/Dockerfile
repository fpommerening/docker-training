FROM composer:latest as builder
WORKDIR /app/
COPY src/* /app/
RUN composer install

FROM php:apache
COPY --from=builder /app/ /var/www/html/


