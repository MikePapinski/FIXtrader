#! /usr/bin/env bash


ROOTDIR=$(dirname ${0})
SBE_SCHEMAS=${ROOTDIR}/*msg.xml
OUTPUTDIR=${ROOTDIR}/Generated

echo "Remove old templates"
if [ -d "$OUTPUTDIR" ]; then rm -Rf $OUTPUTDIR; fi

for f in $SBE_SCHEMAS
do
   echo "Generating schema files for $f"
   sh ./sbe-tool.sh -s $f
done
