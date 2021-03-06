# Number of worker processes to spawn.
# Set to 0 to run everything in a single process without clustering.
# Use 'ncpu' to run as many workers as there are CPU units
num_workers: ncpu

# Log error messages and gracefully restart a worker if v8 reports that it
# uses more heap (note: not RSS) than this many mb.
worker_heap_limit_mb: 250

# Logger info
logging:
  level: info

services:
  - name: kartotherian
    module: ./app.js


    conf:
      port: 6533
      # Comment this out to allow connections from everywhere
      interface: localhost

      variables: /etc/kartotherian/variables.yaml
      sources: /etc/kartotherian/sources.yaml

