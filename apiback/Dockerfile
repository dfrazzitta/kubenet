FROM mcr.microsoft.com/dotnet/aspnet:5.0-focal AS base
WORKDIR /app
EXPOSE 5001
EXPOSE 80

ENV ASPNETCORE_URLS=http://+:5001

RUN apt-get update && \
    apt-get install --no-install-recommends -y \
        arping \
        arptables \
        bridge-utils \
        ca-certificates \
        conntrack \
        curl \
        nano \
        dnsutils \
        ethtool \
        iperf \
        iperf3 \
        iproute2 \
        ipset \
        iptables \
        iputils-ping \
        jq \
        kmod \
        ldap-utils \
        less \
        libpcap-dev \
        man \
        manpages-posix \
        mtr \
        net-tools \
        netcat \
        netcat-openbsd \
        openssl \
        openssh-client \
        psmisc \
        socat \
        tcpdump \
        telnet \
        tmux \
        traceroute \
        tcptraceroute \
        tree \
        ngrep \
        vim \
        wget && \
    rm -rf /var/lib/apt/lists/* && \
    mv /usr/sbin/tcpdump /usr/bin/tcpdump && \
    mv /usr/sbin/traceroute /usr/bin/traceroute

# Creates a non-root user with an explicit UID and adds permission to access the /app folder
# For more info, please refer to https://aka.ms/vscode-docker-dotnet-configure-containers
RUN adduser -u 5678 --disabled-password --gecos "" appuser && chown -R appuser /app
USER appuser

FROM mcr.microsoft.com/dotnet/sdk:5.0-focal AS build
WORKDIR /src
COPY ["apiback/apiback.csproj", "apiback/"]
RUN dotnet restore "apiback/apiback.csproj"
COPY . .
WORKDIR "/src/apiback"
RUN dotnet build "apiback.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "apiback.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "apiback.dll"]
