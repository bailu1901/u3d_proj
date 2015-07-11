#/bin/sh

RootDir=`dirname $0`

cd $RootDir

nohup node webserver.js >a.log 2>&1 & 
