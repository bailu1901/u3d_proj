#/bin/sh

RootDir=`dirname $0`

cd $RootDir

nohup nodejs webserver.js >a.log 2>&1 & 
