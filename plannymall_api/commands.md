# EF Core Scaffold

Scaffold-DbContext "Host=localhost;Database=Plannymall2026;Username=postgres;Password=2071" Npgsql.EntityFrameworkCore.PostgreSQL -OutputDir Models -Context PlannymallContext -Force

# NGROK

ngrok http --host-header=rewrite localhost:5213